using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Data;
using Xunit;

namespace Todo_app.Tests.DataTests
{
    public class PersonSequencerTests
    {
        [Fact]
        public void NextPersonIdTest()
        {
            int personIdNow = PersonSequencer.PersonId;
            int testPersonId = PersonSequencer.NextPersonId();
            Assert.Equal(personIdNow + 1, testPersonId);
        }
        [Fact]
        public void ResetTest()
        {
            PersonSequencer.Reset();
            Assert.Equal(0, PersonSequencer.PersonId);
        }
    }
}
