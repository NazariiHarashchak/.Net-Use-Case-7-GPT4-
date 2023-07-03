using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;
using UseCase_7;

namespace Tests
{
    public class PlayerAnalyzerTests
    {
        private PlayerAnalyzer _analyzer;

        public PlayerAnalyzerTests()
        {
            _analyzer = new PlayerAnalyzer();
        }

        [Fact]
        public void CalculateScore_ShouldHandleNormalPlayer()
        {
            var players = new List<Player>
        {
            new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } }
        };
            var expectedScore = 250;

            double actualScore = _analyzer.CalculateScore(players);

            Assert.Equal(expectedScore, actualScore);
        }

        [Fact]
        public void CalculateScore_ShouldHandleJuniorPlayer()
        {
            var players = new List<Player>
        {
            new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } }
        };
            var expectedScore = 67.5;

            double actualScore = _analyzer.CalculateScore(players);

            Assert.Equal(expectedScore, actualScore, 1);
        }

        [Fact]
        public void CalculateScore_ShouldHandleSeniorPlayer()
        {
            var players = new List<Player>
        {
            new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
        };
            var expectedScore = 2520;

            double actualScore = _analyzer.CalculateScore(players);

            Assert.Equal(expectedScore, actualScore);
        }

        [Fact]
        public void CalculateScore_ShouldHandleMultiplePlayers()
        {
            var players = new List<Player>
        {
            new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } },
            new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } },
            new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
        };
            var expectedScore = 250 + 67.5 + 2520;

            double actualScore = _analyzer.CalculateScore(players);

            Assert.Equal(expectedScore, actualScore, 1);
        }

        [Fact]
        public void CalculateScore_ShouldThrowExceptionWhenSkillsIsNull()
        {
            var players = new List<Player>
        {
            new Player { Age = 25, Experience = 5, Skills = null }
        };

            Assert.Throws<ArgumentNullException>(() => _analyzer.CalculateScore(players));
        }

        [Fact]
        public void CalculateScore_ShouldReturnZeroForEmptyList()
        {
            var players = new List<Player>();

            double actualScore = _analyzer.CalculateScore(players);

            Assert.Equal(0, actualScore);
        }
    }


}
