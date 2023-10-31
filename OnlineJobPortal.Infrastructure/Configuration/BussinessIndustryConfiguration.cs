using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Configuration
{
    public class BussinessIndustryConfiguration : IEntityTypeConfiguration<BussinessIndustry>
    {
        public void Configure(EntityTypeBuilder<BussinessIndustry> builder)
        {
            builder.HasKey(bi => bi.Id);

            builder.Property(bi => bi.BussinessName)
                .IsRequired()
                .HasMaxLength(100);

            var industryList = new List<string>
            {
                "Công nghệ thông tin và phần mềm", "Tài chính và ngân hàng", "Bất động sản",
                "Y tế và chăm sóc sức khỏe", "Giáo dục và đào tạo", "Thương mại điện tử",
                "Dịch sài vụ tài chính và tư vấn", "Sản xuất và công nghiệp",
                "Năng lượng và môi trường", "Thực phẩm và đồ uống", "Du lịch và khách sạn", 
                "Xây dựng và kiến trúc", "Thể thao và giải trí", "Truyền thông và quảng cáo",
                "Vận chuyển và logistics", "Thương mại bán lẻ", "Nông nghiệp và chăn nuôi",
                "Công nghiệp sáng tạo", "Hóa chất và dược phẩm", "Viễn thông và công nghệ truyền thông"
            };

            var industryEntities = new List<BussinessIndustry>();
            int id = 1;

            foreach(var industryName in industryList)
            {
                industryEntities.Add(new BussinessIndustry { Id = id, BussinessName = industryName });
                id++;
            }

            builder.HasData(industryEntities);
        }
    }
}
