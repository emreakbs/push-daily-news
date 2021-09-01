using Moq;
using NUnit.Framework;
using PushDailyNews.Data.Repository.Abstraction;
using PushDailyNews.Infrastructure.Model;
using PushDailyNews.Manager.Abstraction;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace PushDailyNews.Manager.Test
{
    public class BrandManagerTest
    {
        private Mock<IBrandRepository> _brandRepository { get; set; }
        private Mock<IBrandManager> _brandManager { get; set; }


        public BrandManagerTest()
        {
            _brandRepository = new Mock<IBrandRepository>();
        }
        //data hariç diðer katmanlar olucak
        //ElascticSearchManager
        //Search(searchFilterRequest) //reflection, factory desing pattern //chain reponsability
        //CreateIndex(ýndexName) //appsettings'ten url alýcak //index name mehod olucak //
        //AddIndex(BaseElasticSearchModel)
        //PushDailyNewsSearch
        //[Fact]
        //public async Task GetFaq_WithNoFilter_IsEqual()
        //{
        //    _brandRepository.Setup(x => x.GetAllAsync()).ReturnsAsync(new List<BrandModel>());

        //    BrandRequest request = new BrandRequest { Id= };

        //    var response = await _brandManager.GetFaqAsync(request);

        //    Assert.Equal(_faqCacheModel2.FaqTopics.Count, response.Topics.Count);

        //}

        [SetUp]
        public void Setup()
        {
        }


    }
}