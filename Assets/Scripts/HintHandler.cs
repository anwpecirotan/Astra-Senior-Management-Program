using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintHandler : MonoBehaviour
{
    public string firstPageTop;
    public string firstPageBottom;
    // Start is called before the first frame update
    void Start()
    {
        firstPageTop = "Berikut ini disajikan Neraca dan Penghasilan terbaru laporan PT SVA Tbk, sebuah perusahaan " +TemplateData.CompanyName +" di Indonesia";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
