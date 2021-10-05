using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using Primavera.Extensibility.Sales.Editors;
using Primavera.Paymentsds.Mpesa.UI;
using TesBE100;

namespace Primavera.Paymentsds.Mpesa.Sales
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

                        valor = this.DocumentoVenda.TotalDocumento;
                        referencia = form.referencia;

                        //this.DocumentoVenda.CamposUtil["CDU_Mpesa_Valor"].Valor = valor;
                        //this.DocumentoVenda.CamposUtil["CDU_Mpesa_Referencia"].Valor = referencia;

                        string strSerieDocTes, strErro = "", strAvisos = "";

                            
                        TesBEDocumentoTesouraria documentoTesouraria = new TesBEDocumentoTesouraria();
                        strSerieDocTes = BSO.Base.Series.DaSerieDefeito("B", "MOV", DateTime.Now);

                        documentoTesouraria.EmModoEdicao = false;
                        documentoTesouraria.ModuloOrigem = "M";
                        documentoTesouraria.Filial ="000";
                        documentoTesouraria.TipoLancamento = "000";
                        documentoTesouraria.Tipodoc ="MOV";
                        documentoTesouraria.Serie ="2021";
                        documentoTesouraria.Data = DateTime.Now;
                        documentoTesouraria.DataIntroducao=DateTime.Now;
                        documentoTesouraria.TipoEntidade = this.DocumentoVenda.TipoEntidade;
                        documentoTesouraria.Entidade= this.DocumentoVenda.Entidade;
                        documentoTesouraria.ContaOrigem="MP001";
                        documentoTesouraria.Moeda= this.DocumentoVenda.Moeda;
                        documentoTesouraria.Cambio = this.DocumentoVenda.Cambio;
                        documentoTesouraria.CambioMBase = this.DocumentoVenda.CambioMBase;
                        documentoTesouraria.CambioMAlt = this.DocumentoVenda.CambioMAlt;
                        
                        documentoTesouraria.IdDocOrigem = this.DocumentoVenda.ID;
                        documentoTesouraria.AgrupaMovimentos = false;
                        
                        BSO.Tesouraria.Documentos.AdicionaLinha(
                            this.DocumentoTesouraria, 
                            "NUM", 
                            "MP001", 
                            this.DocumentoVenda.Moeda,
                            valor,
                            this.DocumentoVenda.TipoEntidade, 
                            this.DocumentoVenda.Entidade
                       );

                        var numLinha = this.DocumentoTesouraria.Linhas.NumItens;

                        this.DocumentoTesouraria.Linhas.GetEdita(numLinha).DataMovimento = DateTime.Now;
                        this.DocumentoTesouraria.Linhas.GetEdita(numLinha).DataValor = DateTime.Now;
                        this.DocumentoTesouraria.Linhas.GetEdita(numLinha).Cambio = this.DocumentoVenda.Cambio;
                        this.DocumentoTesouraria.Linhas.GetEdita(numLinha).CambioMBase = this.DocumentoVenda.CambioMBase;
                        this.DocumentoTesouraria.Linhas.GetEdita(numLinha).CambioMAlt = this.DocumentoVenda.CambioMAlt;
                        this.DocumentoTesouraria.Linhas.GetEdita(numLinha).Descricao = "Mpesa " + referencia;

                        this.DocumentoTesouraria = documentoTesouraria;
                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void AntesDeIntegrar(ref bool Cancel, ExtensibilityEventArgs e)
        {
            base.AntesDeIntegrar(ref Cancel, e);
        }
    }
}
