using System;
using CQC.TLey.StructureMap.Lib.Impl;
using CQC.TLey.StructureMap.Lib.Interface;
using FluentAssertions;
using NUnit.Framework;
using StructureMap;

namespace CQC.TLey.StructureMap.Lib
{
    [TestFixture]
    public class LifetimeScope
    {
        [Test]
        public void Test1()
        {
            var container = new Container(c =>
                c.For<IEgovHttpClient>().Use<EgovHttpClient>().Transient());

            container.GetInstance<IEgovHttpClient>().Should().BeAssignableTo<EgovHttpClient>();

            var report = container.WhatDoIHave();
            Console.WriteLine(report);
        }

        [Test]
        public void Test2()
        {
            var container = new Container(c =>
                c.For<IEgovHttpClient>().Use<EgovHttpClient>().Transient());

            var i1 = container.GetInstance<IEgovHttpClient>();
            var i2 = container.GetInstance<IEgovHttpClient>();

            i2.Should().NotBe(i1);

        }
        [Test]
        public void Test3()
        {
            var container = new Container(c =>
                c.For<IEgovHttpClient>().Use<EgovHttpClient>().Singleton());

            var i1 = container.GetInstance<IEgovHttpClient>();
            var i2 = container.GetInstance<IEgovHttpClient>();

            i2.Should().Be(i1);
        }

        [Test]
        public void Test4()
        {
            // lets resolve object with dependencies
            var container = new Container(c =>
            {
                c.For<IEgovHttpClient>().Use<EgovLogHttpClient>().Transient();
                c.For<IEgovLogger>().Use<EgovLogger>().Transient();
            });

            var i1 = container.GetInstance<IEgovHttpClient>();
            var i2 = container.GetInstance<IEgovHttpClient>();

            i2.Should().NotBe(i1);

            // same resolve, same instance
            ((EgovLogHttpClient)i1).Logger1.Should().Be(((EgovLogHttpClient)i1).Logger2);

            // another resolve, another instance
            ((EgovLogHttpClient)i1).Logger1.Should().NotBe(((EgovLogHttpClient)i2).Logger1);
            ((EgovLogHttpClient)i1).Logger2.Should().NotBe(((EgovLogHttpClient)i2).Logger2);

            // same resolve, same instance
            ((EgovLogHttpClient)i2).Logger1.Should().Be(((EgovLogHttpClient)i2).Logger2);
            }

        [Test]
        public void Test4A()
        {
            var container = new Container(c =>
            {
                c.For<IEgovHttpClient>().Use<EgovLogHttpClient>().Transient();
                c.For<IEgovLogger>().Use<EgovLogger>().AlwaysUnique();
            });

            var i1 = container.GetInstance<IEgovHttpClient>();
            var i2 = container.GetInstance<IEgovHttpClient>();

            i2.Should().NotBe(i1);

            // always a new instance
            ((EgovLogHttpClient)i1).Logger1.Should().NotBe(((EgovLogHttpClient)i1).Logger2);
            ((EgovLogHttpClient)i1).Logger1.Should().NotBe(((EgovLogHttpClient)i2).Logger1);
            ((EgovLogHttpClient)i2).Logger1.Should().NotBe(((EgovLogHttpClient)i2).Logger2);
        }

        [Test]
        public void Test5()
        {
            var container = new Container(c =>
                c.For<IEgovHttpClient>().Use<EgovHttpClient>().ContainerScoped());
            var nested = container.GetNestedContainer();

            var i1 = container.GetInstance<IEgovHttpClient>();
            var i2 = nested.GetInstance<IEgovHttpClient>();
            var i3 = nested.GetInstance<IEgovHttpClient>();

            i2.Should().NotBe(i1);
            i2.Should().Be(i3);
        }
    }
}
