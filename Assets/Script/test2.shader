Shader "Custom/test2" {  
    Properties {  
        _MainTex ("Base (RGB)", 2D) = "white" {}  
    }  
    SubShader {  
        Tags { "RenderType"="Opaque" }  
        LOD 200  
        Pass {  
            CGPROGRAM  
            #pragma vertex vert_img  
            #pragma fragment frag  
  
            #include "UnityCG.cginc"  
              
            uniform sampler2D _MainTex;  
  
            //fixed4 frag(v2f_img i) : SV_Target {  
            //    float4 c = tex2D(_MainTex, i.uv);  
           //     float f = (c.r+c.g+c.b)/3;  
                  
            //    return float4(f,f,f,1);  
          //  }
            fixed3 rule(Input IN, float3 worldNormal, float period, float width) {  
            float modX = abs(fmod(IN.worldPos.x, period));  
            float modY = abs(fmod(IN.worldPos.y, period));  
            float modZ = abs(fmod(IN.worldPos.z, period));  
  
            float minBorder = width*.5f;  
            float maxBorder = period - width*.5f;  
  
            fixed factorX = 1-abs(dot(worldNormal, float3(1,0,0)));  
            fixed factorY = 1-abs(dot(worldNormal, float3(0,1,0)));  
            fixed factorZ = 1-abs(dot(worldNormal, float3(0,0,1)));  
  
            fixed x = factorX * max(-1 * sign(minBorder - modX) * sign(modX - maxBorder), 0);  
            fixed y = factorY * max(-1 * sign(minBorder - modY) * sign(modY - maxBorder), 0);  
            fixed z = factorZ * max(-1 * sign(minBorder - modZ) * sign(modZ - maxBorder), 0);  
            fixed v = saturate(x+y+z);  
            return fixed3(v,v,v);  
        }
        fixed3 radar(Input IN, float period, float fade) {  
            float distFromCam = length(IN.worldPos - _WorldSpaceCameraPos);  
            float x = distFromCam / period - _Time.y / 4;  
            float sawtooth = (x - floor(x)) * period;  
            fixed v = saturate((sawtooth - (period - fade)) / fade) / (1+distFromCam);  
            return fixed3(v,v,v);  
        }      
            ENDCG  
        }  
    }  
}  