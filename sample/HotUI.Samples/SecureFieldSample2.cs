﻿using System;
using System.Collections.Generic;

/*

struct ContentView : View {
    @State private var password: String = ""

    var body: some View {
        VStack {
            SecureField("Enter a password", text: $password)
            Text("You entered: \(password)")
        }
    }
}

*/
namespace HotUI.Samples
{
    public class SecureFieldSample2 : View
    {
        readonly State<string> password = new State<string>("");
        
        public SecureFieldSample2()
        {
            Body = () => new VStack
            {
                new SecureField(null, "Enter a password", value => password.Value = value),
                new Text(password.Value)
            };
        }
    }
}