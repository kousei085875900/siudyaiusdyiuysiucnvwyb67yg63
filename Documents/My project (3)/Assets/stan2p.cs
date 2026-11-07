using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stan2p : MonoBehaviour
{
    public static float stungage2p = 0;
    public static Slider slider2p;
    public static bool stun_on_off2p = false;
    //-----------------------------------------------------------
    // ��礵���댝�󣨤�����Behaviour�ˉ������Ƥ��룩
    [SerializeField] private Behaviour _target;
    // �������[s]
    [SerializeField] private float _cycle;
    private double _time;
    //-----------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        slider2p = GetComponent<Slider>();
        slider2p.value = stungage2p;
    }

    // Update is called once per frame
    void Update()
    {
        if (stungage2p > 1)
        {
            stungage2p -= 0.04f;
            slider2p.value = stungage2p;
        }


        if (stungage2p >= 0 && stun_on_off2p)
        {
            stungage2p -= 0.1f;
            slider2p.value = stungage2p;
            if (stungage2p < 0)
            {
                stungage2p = 0;
            }
        }


        if (stungage2p > 99)
        {
            stun_on_off2p = true;
        }
        else
        {
            _target.enabled = false;
        }
        /*
        
         */
        if (stun_on_off2p)
        {
            // �ڲ��r�̤�U�^������
            _time += Time.deltaTime;
            // ����cycle���R�귵������ȡ��
            // 0��cycle�ι���΂����ä���
            var repeatValue = Mathf.Repeat((float)_time, _cycle);

            // �ڲ��r��time�ˤ���������״�B��ӳ
            _target.enabled = repeatValue >= _cycle * 0.5f;

        }

        if (stungage2p == 0)
        {
            stun_on_off2p = false;
        }

        slider2p.value = stungage2p;
    }
}
