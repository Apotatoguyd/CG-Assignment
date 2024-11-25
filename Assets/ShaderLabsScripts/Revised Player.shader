Shader "Custom/Revised Player"
{
    Properties
    {
      _MainTex("Maintex", 2D) = "white"{}
     // _RimColor("Rim Color", Color) = (0,0.5,0.5,0.0)
     // _RimPower("Rim Power", Range(0.5,8.0)) = 3.0
       _Color ("Color", Color) = (1,1,1,1)
        _RampTex ("RampTexture", 2D) = "white"{}
         _ColorTint ("Tint", Color) = (1.0, 0.6, 0.6, 1.0)
          _Amount("Extrude", Range(-1,2)) = 0.01
        _OutlineColor ("Outline Color", Color) = (0,0,0,1)
        _Outline ("Outline Width", Range (0.02,1)) = .005
    }
    SubShader
    {
        Tags { "Queue" = "Transparent" }
     
        Pass {
            ZWrite On
            ColorMask 0 
            }

        CGPROGRAM
        #pragma surface surf ToonRamp finalcolor:mycolor
        float4 _Color;
        sampler2D _RampTex;
        sampler2D _MainTex;

                float4 LightingToonRamp (SurfaceOutput s, fixed3 lightDir, fixed atten)
        {            
            float diff = dot (s.Normal, lightDir);
            float h = diff * 0.2+0.5;
            float2 rh = h;
            float3 ramp = tex2D(_RampTex, rh).rgb;

            float4 c;
            c.rgb = s.Albedo * _LightColor0.rgb * (ramp);
            c.a = s.Alpha;
            return c;
        }

        struct Input
        {
            float3 viewDir;
            float2 uv_MainTex;
        };

       //  float4 _RimColor;
      //   float _RimPower;
         fixed4 _ColorTint;
        void mycolor (Input IN, SurfaceOutput o, inout fixed4 color){
               color *= _ColorTint;
            }

        void surf (Input IN, inout SurfaceOutput o)
        {
            o.Albedo = _Color.rgb;
            o.Albedo = tex2D (_MainTex, IN.uv_MainTex).rgb;
            //half rim = 1.0 - saturate(dot(normalize(IN.viewDir), o.Normal));
           // o.Emission = _RimColor.rgb * pow(rim, _RimPower) * 10;
          //  o.Alpha - pow(rim, _RimColor);
        }
        ENDCG
         Pass
        {
            Cull Front
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                };

            struct v2f {
                float4 pos : SV_POSITION;
                fixed4 color : COLOR;

                };

            float _Outline;
            float4 _OutlineColor;

            v2f vert (appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);

                float3 norm =  normalize(mul ((float3x3)UNITY_MATRIX_IT_MV, v.normal));
                float2 offset = TransformViewToProjection(norm.xy);

                o.pos.xy += offset * o.pos.z * _Outline;
                o.color = _OutlineColor;
                return o;
                }

                fixed4 frag(v2f i): SV_Target{
                    return i.color;
                    }
                    ENDCG
         }
         Pass
        {
           Tags {"LightMode" = "ShadowCaster"}
           CGPROGRAM
           #pragma vertex vert
           #pragma fragment frag
           #pragma multi_compile_shadowcaster
           #include "UnityCG.cginc"
           struct appdata {
           float4 vertex : POSITION;
           float3 normal : NORMAL;
           float4 texcoord : TEXCOORD0;
       };
       struct v2f {
       V2F_SHADOW_CASTER;
       };
       v2f vert(appdata v)
       {
           v2f o;
           TRANSFER_SHADOW_CASTER_NORMALOFFSET(o)
           return o;
       }
       float4 frag(v2f i) : SV_Target
       {
           SHADOW_CASTER_FRAGMENT(i)
       }
       ENDCG
        }
    }
    
}
