using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Business
{

    public class ImprimirTela
    {
        PrintDocument impressora;

        Bitmap imagemImpressao;

        Panel panelImpressao;

        Form tela;

        public ImprimirTela()
        {
            this.impressora = new PrintDocument();
            this.impressora.PrintPage += Impressora_PrintPage;
        }
        public void Imprimir(Form tela, Panel panelImpressao)
        {
            this.panelImpressao = panelImpressao;
            this.tela = tela;
            this.CapturarAreaDeImpressao();
            this.impressora.Print();
        }
        private void Impressora_PrintPage(object sender, PrintPageEventArgs e)

        {
            e.Graphics.DrawImage(this.imagemImpressao, 0, 0);
        }
        private void CapturarAreaDeImpressao()
        {
            Graphics interfaceGrafica = this.tela.CreateGraphics();

            Size tamanhoPanel = this.panelImpressao.Size;

            imagemImpressao = new Bitmap(tamanhoPanel.Width, tamanhoPanel.Height, interfaceGrafica);

            Graphics memoryGraphics = Graphics.FromImage(imagemImpressao);

            memoryGraphics.CopyFromScreen(this.tela.Location.X + this.panelImpressao.Location.X,

                                          this.tela.Location.Y + this.panelImpressao.Location.Y,

                     0, 0, tamanhoPanel);
        }
    }
}
