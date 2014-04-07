CrossDomainConnectionTool
=========================

NOTE: This tool is overly simple - don't expect much but the basic functionality. 


Simple little tool that allows cross domain connection of Sql Server (or other tools with modification) to connect to servers on another domain. 

Background: This tool came about because I dispise the need to remote into another server just to access a database through SSMS. In an environment with disparate networks for development and production servers I was unable to find a tool or extension that would allow me to use my local installation of SSMS to connect to the database.

This tool will also be handy if you work with multiple clients and need to access databases on that front. It can be a hassle to use a remote instance, or (worse) need to wait for an available computer that is on the domain. With this tool you just need a user account setup on the domain hosting the DB. 
