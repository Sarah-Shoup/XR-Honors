Shader "Custom/Portal window"
{
   SubShader
    {
        ZWrite off
        ColorMask 0

        Stencil{
            Ref 1
            Pass replace
        }

        Pass{

        }
    }
}
