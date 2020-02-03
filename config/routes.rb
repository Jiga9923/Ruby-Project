Rails.application.routes.draw do
  resources :numbers
 	get '/calculate', :controller=>'calculator', :action=>'calculate'
	post '/sum', :controller=>'calculator', :action=>'sum'
	post '/subtract', :controller=>'calculator', :action=>'subtract'
	post '/multiply', :controller=>'calculator', :action=>'multiply'
	post '/division', :controller=>'calculator', :action=>'division'
end
