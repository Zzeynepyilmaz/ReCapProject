using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal:IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color{ColorId=1,ColorName="Siyah"},
                new Color{ColorId=2,ColorName="Beyaz"},
                new Color{ColorId=3,ColorName="Gri"},
                new Color{ColorId=4,ColorName="Lacivert"},
                new Color{ColorId=5,ColorName="Kırmızı"}
            };
        }
        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color ColorToDelete= _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            _colors.Remove(ColorToDelete);
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Color color)
        {
            Color ColorToUpdate= _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            ColorToUpdate.ColorName = color.ColorName;
        }

        
    }
}
