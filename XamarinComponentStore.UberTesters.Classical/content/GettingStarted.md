ComponentName fast XML and binary serialization.

Cross-platform port by HolisticWare:

* 	Windows Phone
* 	Xamarin.iOS
* 	Xamarin.Android

```csharp
		public static void SerializeComponentNameBinary(Person p)
		{
			// create instance of sharpSerializer
			// true - binary serialization, false - xml serialization
			var serializer = new Polenter.Serialization.ComponentName(true);

			// serialize
			serializer.Serialize(p, "Person.ComponentName.bin");

			return;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="p"></param>
		public static void SerializeComponentNameXml(Person p)
		{
			// create instance of sharpSerializer
			// true - binary serialization, false - xml serialization
			var serializer = new Polenter.Serialization.ComponentName(false);

			// serialize
			serializer.Serialize(p, "Person.ComponentName.xml");

			return;
		}


		public static Person DeserializeComponentNameBinary()
		{
			Person p = default(Person);

			// create instance of sharpSerializer
			// true - binary serialization, false - xml serialization
			var serializer = new Polenter.Serialization.ComponentName(true);

			// deserialize
			p = (Person) serializer.Deserialize("Person.ComponentName.bin");

			return p;
		}

		public static Person DeserializeComponentNameXml()
		{
			Person p = default(Person);

			// create instance of sharpSerializer
			// true - binary serialization, false - xml serialization
			var serializer = new Polenter.Serialization.ComponentName(false);

			// deserialize
			p = (Person)serializer.Deserialize("Person.ComponentName.xml");

			return p;
		}

```

## Other Resources

* 	[http://sharpserializer.codeplex.com](http://sharpserializer.codeplex.com)
* 	[http://www.sharpserializer.com](http://www.sharpserializer.com)
* 	[http://holisticware.net](http://holisticware.net)
