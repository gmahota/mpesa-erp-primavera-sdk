using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.CustomForm;

namespace Primavera.Paymentsds.Mpesa.UI
{
    public partial class FDU_PagMpesa : CustomForm
    {
        public bool pagMpesa { get; set; }
        public double total { get; set; }
        public string referencia { get; set; }

        public FDU_PagMpesa()
        {
            InitializeComponent();
        }

        public void Initialize(string tipoDoc, string serie, int numdoc)
        {
            try
            {
                cbTipoDoc.SelectedValue = tipoDoc;
                cbSerie.SelectedValue = serie;
                txtNumdoc.Value = numdoc;

                pagMpesa = false;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            referencia = txtReferencia.Text;
            total = Convert.ToDouble( txtTotal.Value);
            pagMpesa = true;
            Close();
        }
    }
}
