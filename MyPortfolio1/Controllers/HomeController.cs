using Microsoft.AspNetCore.Mvc;
using MyPortfolio1.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace MyPortfolio1.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Portfolio> _portfolios = new List<Portfolio>
        {
            new Portfolio
            {
                Id = 1, Title = "پای سیب دارچینی", Image = "apple.webp", Description = "ترکیب سیب کاراملی و دارچین، با خمیر ترد و خوش عطر...\r\nیه طعم آشنا که انگار از دل یه عصر پاییزی قدیمی اومده. پر از آرامش. فقط یه تیکه ازش کافیه تا یادت بیاد چقدر ساده ها قشنگ  تر بودن."
            },
            new Portfolio
            {
                Id = 2, Title = "کوکی شکلات تلخ", Image = "cookies-3.jpg", Description = "برای وقتی که دلت یه طعم جدی و عمیق میخواد....\r\nیه گاز که بزنی، دلت میخواد همه ی خستگی روزتو باهاش بخوری.\r\n برای وقتایی که شیرینی کافی نیست."
            },
            new Portfolio
            {
                Id = 3, Title = "فاج شکلاتی", Image = "faj.jpg",
                Description = "یه تیکه کوچیک اما پر طعم...\r\n شکلات غلیظ، بافت مخملی، و یه حس عمیق که تا لحظه آخر توی دهنت می مونه. انگار یه تیکه شکلات داره آروم توی دلت آب میشه."
            },
            new Portfolio
            {
                Id = 4, Title = "ماکارون", Image = "macaron1.jpg",
                Description = "پوسته ای ترد، قلبی نرم و خامه ای...\r\n هر ماکارون  یه گاز کوچک از شادیه؛ سبک، شیرین، رنگی رنگی، برای لحظه هایی که دلت یه حال خوب میخواد."
            },
            new Portfolio
            {
                Id = 5, Title = "تارت لیمویی", Image = "tart-limooei2.jpg",
                Description = "طعمی ترش و ملایم که لیموی تازه میاد و رنگی روشن و درخشان همچون خورشید، شیرین و خوش بو با روکشی از مرنگ."
            }
        };

        public IActionResult Index()
        {
            ViewData["headingTitle"] = "به سایت شخصی من خوش آمدید";

            ViewBag.headingText =
                "این سایت به جهت معرفی من به مشتریان و کسانی که می خواهند از خدمات سایت بهره مند شوند طراحی و پیاده سازی شده است";

            return View(_portfolios);
   
        }

        public IActionResult Contact()
        {
            var contact = new Contact()
            {
                Email = "Najmeh.86@.com",
                Mobile = "0000000000000",
                Github = "github.com/nilofarnr"
            };
            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}