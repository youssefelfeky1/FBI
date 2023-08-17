<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="PresentationWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       
        .classa{
    
    font-size: large;
    margin-left: 30px;
    width: 600px;
    padding: 10px;
    background-color:blanchedalmond;
    display: inline-block;
    border-radius: 50px;
    padding: 30px;

}
.classb{

background-color:blanchedalmond;
    width: 600px;
    height: 440px;
    margin-left: 70px;
    margin-right: 60px;
    display: inline-block;
    border-radius: 50px;
    padding: 30px;
}
.container{
    display: flex;
}
form input{
    padding-bottom: 25px;
    margin-left: 20px;
    margin-top: 10px;
    margin-bottom: 10px;
    width: 90%;
    height: 4%;
    border-top: 1px solid #999;
    border-right: 1px solid #999;
    border-left: 1px solid #999;
    border-bottom: 2px solid #999;
    border-radius: 10px;
}

.btn{
 height: 40px;
 width: 100px;
 font-size: large;
 border-radius: 15px;
}
.btn:hover{
    background-color:brown;
  color: white;
    width: 120px;
    height: 50px;
    
    
}
.btn2{
 height: 40px;
 width: 100px;
 font-size: large;
 border-radius: 15px;
}
.btn2:hover{
    background-color:brown;
  color: white;
    width: 120px;
    height: 50px;
    
    
}
.center{
    display: flex;
    justify-content: center;
    
}
h1{ text-align: center;
}
h2{
    text-align: center;
}
    </style>
</head>
<body>
        <h1>ISSUE</h1>

    <div class="container">
    
    <div class="classa">
        <h2>Add</h2>
    <form>
        <label for="name">Name:</label>
        <input type="text" name="name" id="namee"placeholder="Enter Name"><br>
        <br>
        <label for="desc"> Description:</label>
        <input type="text" name="desc" id="desc" placeholder="Enter Description"><br>
        <br>
        <label for="url"> URL:</label>
        <input type="text" name="url" id="url" placeholder="Enter URL"> <br>
        <br>
         <div class="center"><button class="btn">ADD</button></div>
    </form>
</div>

<div class="classb">
    <h2>Search</h2>
    <form >
        <label for="name">Name:</label>
        <input type="text" name="name" id="name" placeholder="Enter Name"><br>
        <br>
      <div class="center"> <button class="btn2">Search</button></div> 
    </form>
</div>
</div>
</body>
</html>
