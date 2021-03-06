﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;

public class Chat : StatefulWidget
{
    public override State createState()
    {
        return new _ChatState();
    }

    class _ChatState : State<Chat>
    {
        public override void initState()
        {
            base.initState();
        }

        public override void dispose()
        {
            base.dispose();
        }

        public override Widget build(BuildContext context) 
        {
            return new Scaffold(
                appBar: new AppBar(
                    title: new Text(
                        "Chat",
                        style: new TextStyle(
                            color: Colors.black
                        )
                    ),
                    backgroundColor: Colors.white,
                    elevation: 0
                )
            );
        }
    }
}
