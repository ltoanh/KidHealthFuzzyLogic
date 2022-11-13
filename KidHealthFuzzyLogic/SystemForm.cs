using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidHealthFuzzyLogic
{
    public partial class SystemForm : Form
    {
        public SystemForm()
        {
            InitializeComponent();
            var treEm = Common.Gender == 0 ? "bé trai" : "bé gái";
            this.Text = $"Hệ thống đánh giá sự phát triển {treEm} {Common.Age} tuổi";
            // khởi tạo bộ câu hỏi
            InitQuestion();
        }
        /// <summary>
        /// Khởi tạo bộ câu hỏi
        /// </summary>
        private void InitQuestion()
        {
            switch (Common.Age)
            {
                case 2:
                    // 1.2 tuổi
                    // 1.1. Vận động thô
                    gr_VDTH_C1.Text = "Câu 1: Con của bạn có thể chạy khá vững và tự dừng lại mà không cần va chạm vào vật hoặc không bị té ngã không?";
                    gr_VDTH_C2.Text = "Câu 2: Con của bạn có đá được quả bóng bằng cách vung chân về phía trước mà không cần phải vịn vào bất cứ điểm tựa nào không?";
                    gr_VDTH_C3.Text = "Câu 3: Con của bạn có thể nhảy với hai chân rời khỏi mặt đất cùng một lúc được không?";
                    gr_VDTH_C4.Text = "Câu 4:Khi đi lên cầu thang, con bạn có thể bước lần lượt từng chân lên mỗi bậc thang không? Bé có thể vịn vào tay vịn cầu thang hoặc tường.";
                    gr_VDTH_C5.Text = "Câu 5:Con của bạn có thể đứng một chân trong khoảng 1 giây mà không cần vịn vào bất cứ vật gì không?";
                    gr_VDTH_C6.Text = "Câu 6:Khi đứng, con của bạn có thể ném bóng bằng cách đưa cánh tay lên ngang vai, tay cầm bóng cao hơn vai, và ném bóng về phía trước không?";
                    // 1.2. Vận động tinh
                    gr_VDT_C1.Text = "Câu 1:Sau khi con của bạn quan sát bạn vẽ một đường thẳng dọc từ đầu đến cuối trang giấy, bé bắt chước vẽ giống đường thẳng bạn đã vẽ mà không được đồ/tô lại. Bé có vẽ được không?";
                    gr_VDT_C2.Text = "Câu 2:Con của bạn có biết xâu hạt thành chuỗi không?";
                    gr_VDT_C3.Text = "Câu 3:Sau khi con của bạn quan sát bạn vẽ một đường thẳng ngang từ trái sang phải trang giấy, bé bắt chước vẽ giống đường thẳng bạn đã vẽ mà không được đồ/tô lại. Bé có vẽ được không?";
                    gr_VDT_C4.Text = "Câu 4:Sau khi con của bạn quan sát bạn vẽ mẫu một đường tròn trên tờ giấy, hãy yêu cầu bé bắt chước vẽ giống đường tròn bạn đã vẽ mà không được đồ/tô lại. Bé có vẽ được không?";
                    gr_VDT_C5.Text = "Câu 5:Con của bạn có biết lật từng trang sách không?";
                    gr_VDT_C6.Text = "Câu 6:Con của bạn có thử cắt giấy bằng kéo dành cho trẻ em không? Bé có thể không cắt được giấy nhưng cần phải biết cử động sao cho lưỡi kéo đóng và mở.";
                    break;

                case 3:
                    // 2. 3 tuổi
                    // 2.1. Vận động thô
                    gr_VDTH_C1.Text = "Câu 1:Con của bạn có đá được quả bóng bằng cách vung chân về phía trước mà không cần phải vịn vào bất cứ điểm tựa nào không?";
                    gr_VDTH_C2.Text = "Câu 2:Con của bạn có thể nhảy với hai chân rời khỏi mặt đất cùng một lúc được không?";
                    gr_VDTH_C3.Text = "Câu 3:Khi đi lên cầu thang, con bạn có thể bước lần lượt từng chân lên mỗi bậc thang không? Bé có thể vịn vào tay vịn cầu thang hoặc tường.";
                    gr_VDTH_C4.Text = "Câu 4:Con của bạn có thể đứng một chân trong khoảng 1 giây mà không cần vịn vào bất cứ vật gì không?";
                    gr_VDTH_C5.Text = "Câu 5:Khi đứng, con của bạn có thể ném bóng bằng cách đưa cánh tay lên ngang vai, tay cầm bóng cao hơn vai, và ném bóng về phía trước không?";
                    gr_VDTH_C6.Text = "Câu 6:Con của bạn có thể bật nhảy về phía trước khoảng 6 inches/16cm với cả hai chân rời khỏi mặt đất cùng lúc không?";
                    // 2.2. Vận động tinh
                    gr_VDT_C1.Text = "Câu 1:Sau khi con của bạn quan sát bạn vẽ một đường thẳng dọc từ đầu đến cuối trang giấy, bé bắt chước vẽ giống đường thẳng bạn đã vẽ mà không được đồ/tô lại. Bé có vẽ được không?";
                    gr_VDT_C2.Text = "Câu 2:Con của bạn có biết xâu hạt thành chuỗi không?";
                    gr_VDT_C3.Text = "Câu 3:Sau khi con của bạn quan sát bạn vẽ một đường thẳng ngang từ trái sang phải trang giấy, bé bắt chước vẽ giống đường thẳng bạn đã vẽ mà không được đồ/tô lại. Bé có vẽ được không?";
                    gr_VDT_C4.Text = "Câu 4:Sau khi con của bạn quan sát bạn vẽ mẫu một đường tròn trên tờ giấy, hãy yêu cầu bé bắt chước vẽ giống đường tròn bạn đã vẽ mà không được đồ/tô lại. Bé có vẽ được không?";
                    gr_VDT_C5.Text = "Câu 5:Con của bạn có thử cắt giấy bằng kéo dành cho trẻ em không? Bé có thể không cắt được giấy nhưng cần phải biết cử động sao cho lưỡi kéo đóng và mở.";
                    gr_VDT_C6.Text = "Câu 6:Khi vẽ, con của bạn có cầm bút chì, (bút màu/bút bi) ở giữa các ngón tay và ngón tay cái như người lớn không?";
                    break;

                case 4:
                case 5:
                    // 3. 4 tuổi
                    // 3.1. Vận động thô
                    gr_VDTH_C1.Text = "Câu 1: Khi đứng, con bạn có thể ném bóng về phía người đối diện đứng cách trẻ ít nhất khoảng 6 feet/2 m không? Để ném bóng, bé phải giơ tay cao ngang vai và ném bóng về phía trước";
                    gr_VDTH_C2.Text = "Câu 2: Con của bạn có thể bắt được một quả bóng to bằng cả hai bàn tay không? (Bạn hãy đứng cách xa bé khoảng 5 feet/1.5 m và cho bé thử 2–3 lần trước khi đánh dấu trả lời.)";
                    gr_VDTH_C3.Text = "Câu 3: Không phải bám vào vật gì, con bạn có thể đứng bằng một chân ít nhất trong 5 giây mà không bị mất thăng bằng hay phải hạ chân kia xuống không?";
                    gr_VDTH_C4.Text = "Câu 4: Trẻ có thể đi kiễng/đi nhón trên đầu ngón chân được khoảng 15 feet/4.5 m (bằng chiều dài của một chiếc ô tô lớn) không?";
                    gr_VDTH_C5.Text = "Câu 5: Con của bạn có nhảy lò cò được khoảng 4–6 feet/1–2 m mà không phải hạ chân kia xuống? (Đánh dấu “thỉnh thoảng” nếu bé chỉ nhảy lò cò được trên một chân.)";
                    gr_VDTH_C6.Text = "Câu 6: Con của bạn có biết chạy tung tăng luân phiên từng chân một không?";
                    // 3.2. Vận động tinh
                    gr_VDT_C1.Text = "Câu 1: Cho con bạn tô theo dòng kẻ dưới đây bằng bút chì. Bé có tô theo đường kẻ mà không bị chệch ra ngoài nhiều hơn 2 lần không?";
                    gr_VDT_C2.Text = "Câu 2:Yêu cầu con của bạn vẽ một hình người. Nếu bé vẽ được cả 4 bộ phận: đầu, thân, tay, và chân, đánh dấu “có”, 3 trong 4 bộ phận trên, đánh dấu “thỉnh thoảng”, còn lại, đánh dấu trả lời “chưa”";
                    gr_VDT_C3.Text = "Câu 3: Bạn vẽ một đường thẳng cắt ngang tờ giấy, con của bạn dùng kéo và cắt tờ giấy làm đôi theo đường thẳng này, đường cắt không cần phải thẳng hoàn toàn. Con có làm được không?";
                    gr_VDT_C4.Text = "Câu 4: Yêu cầu con của bạn vẽ lại các hình (không để bé tô lại hình mẫu), con bạn có làm được không? (Hình bé vẽ phải tương tự với hình mẫu nhưng có thể có kích thước khác nhau";
                    gr_VDT_C5.Text = "Câu 5: Cho con của bạn nhìn vào các chữ cái theo mẫu chữ in hoa, yêu cầu con vẽ lại các chữ mà không tô lại hình mẫu";
                    gr_VDT_C6.Text = "Câu 6: Viết tên của con bạn bằng chữ in hoa. Con có thể bắt chước vẽ lại các chữ cái trong tên mình không? Con có thể vẽ chữ to, viết ngược, hoặc không theo thứ tự.";
                    break;
                default:
                    break;

            }

        }

        /// <summary>
        /// Tính kết quả bộ câu hỏi đánh giá chỉ số vận động thô
        /// </summary>
        private void CalcVanDongTho()
        {
            var result = 0;
            //C1
            if (VDTH_rb_C_1.Checked)
            {
                result += 10;
            } else if (VDTH_rb_DK_1.Checked)
            {
                result += 5;
            } else if (VDTH_rb_H_1.Checked)
            {
                result += 0;
            }

            //c2
            if (VDTH_rb_C_2.Checked)
            {
                result += 10;
            }
            else if (VDTH_rb_DK_2.Checked)
            {
                result += 5;
            }
            else if (VDTH_rb_H_2.Checked)
            {
                result += 0;
            }

            //c3
            if (VDTH_rb_C_3.Checked)
            {
                result += 10;
            }
            else if (VDTH_rb_DK_3.Checked)
            {
                result += 5;
            }
            else if (VDTH_rb_H_3.Checked)
            {
                result += 0;
            }

            //c4
            if (VDTH_rb_C_4.Checked)
            {
                result += 10;
            }
            else if (VDTH_rb_DK_4.Checked)
            {
                result += 5;
            }
            else if (VDTH_rb_H_4.Checked)
            {
                result += 0;
            }

            //c5
            if (VDTH_rb_C_5.Checked)
            {
                result += 10;
            }
            else if (VDTH_rb_DK_5.Checked)
            {
                result += 5;
            }
            else if (VDTH_rb_H_5.Checked)
            {
                result += 0;
            }

            //c6
            if (VDTH_rb_C_6.Checked)
            {
                result += 10;
            }
            else if (VDTH_rb_DK_6.Checked)
            {
                result += 5;
            }
            else if (VDTH_rb_H_6.Checked)
            {
                result += 0;
            }

            Common.VDTH = result;
        }

        /// <summary>
        /// Tính kết quả bộ câu hỏi đánh giá chỉ số vận động tinh
        /// </summary>
        private void CalcVanDongTinh()
        {
            var result = 0;
            //c1
            if (VDT_rb_C_1.Checked)
            {
                result += 10;
            } else if (VDT_rb_DK_1.Checked)
            {
                result += 5;
            } else if (VDT_rb_H_1.Checked)
            {
                result += 0;
            }
            //c2
            if (VDT_rb_C_2.Checked)
            {
                result += 10;
            }
            else if (VDT_rb_DK_2.Checked)
            {
                result += 5;
            }
            else if (VDT_rb_H_2.Checked)
            {
                result += 0;
            }
            //c3
            if (VDT_rb_C_3.Checked)
            {
                result += 10;
            }
            else if (VDT_rb_DK_3.Checked)
            {
                result += 5;
            }
            else if (VDT_rb_H_3.Checked)
            {
                result += 0;
            }
            //c4
            if (VDT_rb_C_4.Checked)
            {
                result += 10;
            }
            else if (VDT_rb_DK_4.Checked)
            {
                result += 5;
            }
            else if (VDT_rb_H_4.Checked)
            {
                result += 0;
            }
            //c5
            if (VDT_rb_C_5.Checked)
            {
                result += 10;
            }
            else if (VDT_rb_DK_5.Checked)
            {
                result += 5;
            }
            else if (VDT_rb_H_5.Checked)
            {
                result += 0;
            }
            //c6
            if (VDT_rb_C_6.Checked)
            {
                result += 10;
            }
            else if (VDT_rb_DK_6.Checked)
            {
                result += 5;
            }
            else if (VDT_rb_H_6.Checked)
            {
                result += 0;
            }

            Common.VDT = result;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // tính các chỉ số
            CalcVanDongTho();
            CalcVanDongTinh();
        }
    }
}
