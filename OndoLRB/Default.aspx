<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="wrapper">
			<div class = "container-bg">
			<div class="banner"></div>
			<div class="container">
				<div class ="content">
				<ul class="nav">
					<a href = "#"><li>HOME</li></a>
					<a href = "#"><li>ABOUT</li></a>
					<a href = "#"><li>APPLY</li></a>
					<a href = "#"><li>CONTACTS</li></a>
					<a href = "#"><li>FAQ</li></a>
				</ul>
				<div class="top_box">
				<div class="action_box_third">
					<h2>Create an Account</h2>
					<p>
						Sign up to become a registered user. Only registered members will have 
						access to application forms.
					</p>
					<a href ="User/Forms/Default.aspx">
					<img class = "icon" src="App_Themes/Default/img/sign-up.png" />
                     </a>
				</div>
				<div class="action_box_third">
					<h2>Title Search</h2>
					<p>
						Search for registered Land and Cadastral<br /> with the ODSG by Titles,<br/>
						Name or Location.
					</p>
					<a href ="#">
					<img class = "icon" src="App_Themes/Default/img/analysis.png" />
                    </a>
				</div>
				<div class="action_box_third">
					<h2>Application Forms</h2>
					<p>
						You can apply for allocation of land, track<br /> your application and get<br />
						your C of O here.
					</p>
					<a href ="User/Forms/Default.aspx">
					<img class = "icon" src="App_Themes/Default/img/application-form.png" />
                    </a>
				</div>
				</div>
				<div class="bottom_box">
				<div class="main_box">
					<h2>Welcome to Land Records Bureau</h2>
					<img src="App_Themes/Default/img/gov.gif" style="float: left;"/>
					<p style="text-align:justify"><strong>Welcome</strong> 
                 to the official website of the Ondo State Land Recods Bureau. 
                            The Bureau was commissioned on July 10, 2012 with a simple mandate: to enhance 
                            the value of our land assets, about 15,500 sq km, by providing a transparent, 
                            secure, affordable and customer-friendly land management services for both the 
                            public and the private sector. To this end, we are building a trustworthy platform, 
                            for both land owners and buyers, which enhances title credibility by ensuring that all 
                            land related transactions could be conducted securely and in a fraud-free environement. 
                            For land owners, we have put in place a transparent process to ensure timely processing and 
                            issuance of land title by deploying this website through which anyone could file land title 
                            application and track the application status. Soon, all land title application processing fees 
                            would be paid via this website. For land or property buyers, mortgage institutions, and property 
                            managers and public at large, the Bureau’s website could also be used to conduct exhaustive land 
                            title search, and file caveats, leases, and mortgage information. Our commitment to becoming the 
                            number one investment destination for land and housing in the country is borne out by being the 
                            <strong> first state in Nigeria to provide online land title application and land title search.</strong> These are 
                            some of the steps we are taking to ensure that we achieve our goal of <strong> Capitalization of                            
                             Land Resources,</strong> a major initiative of my administration. Once again, I welcome you to our website 
                            and I invite you to email your comments and suggestions about how we can serve you better to info@odsglrb.gov.ng.
 </p>
				</div>
				<div class="side_box"></div>
				</div>
				</div>
			</div>
			</div>
		</div>
</asp:Content>

