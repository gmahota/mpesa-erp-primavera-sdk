using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using Primavera.Extensibility.POS.Editors;
using Primavera.Paymentsds.Mpesa.UI;

namespace Primavera.Paymentsds.Mpesa.POS
{
    public class UiEditorVendas : EditorVendas
    {
        public override void TeclaPressionada(int KeyCode, int Shift, ExtensibilityEventArgs e)
        {
            base.TeclaPressionada(KeyCode, Shift, e);

            try
            {
                string tipodoc = this.DocumentoVenda.Tipodoc;
                string serie = this.DocumentoVenda.Serie;
                int numdoc = this.DocumentoVenda.NumDoc;
                double valor = 0;
                string referencia = "";
                if (Shift == 2 && (KeyCode == 109 || KeyCode == 77))
                {
                    var result1 = BSO.Extensibility.CreateCustomFormInstance(typeof(FDU_PagMpesa));
                    {
                        var form = (result1.Result as FDU_PagMpesa);
                        form.Initialize(tipodoc, serie, numdoc);

                        form.ShowDialog();

                        valor = form.total;
                        referencia = form.referencia;

                       

                    }
                }

      
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
