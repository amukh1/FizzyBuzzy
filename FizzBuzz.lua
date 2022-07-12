local x = 15

for i=1, x, 1 do
local resp = ""
if i % 3 == 0 then
   resp = resp .. "Fizz"
  end
if i % 5 == 0 then 
   resp = resp .."Buzz"
  end
if (i % 5 ~= 0 and i % 3 ~= 0) then
   resp = i
end
print(resp)
end
