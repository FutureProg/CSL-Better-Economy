# Better Economy Mod

* Past a certain amount require road maintenance building?
* Past a certain number require park mantenance building?
* Past certain number of homes/population, full-time fire fighter hires per buildings&people/km squared ((residences + jobs) / population)
* Minimum Wage: 1500 ($15)

## City Internal Expenses (Employees, Equipment)
* Road maintenance employees + equipment per km of road
* Accountants
* Urban Planners
* City Councilors per people+jobs per km of land
* School board
* Park Maintenace staff

## Roads
* If possible, maintance and cost by road type

## Water
* Increase cost and maintenace
* 

## Electricity
* 

## Tax Revenue
* Balance revenues to cost (game doesn't give enough money)
* Income Tax Revenue policy?
* Land Value Tax
* Remove tax-treasury adjustment https://www.reddit.com/r/CitiesSkylines/comments/6qe2um/more_money_in_funds_less_weekly_income/


**API Links**
http://static.croxford.me/CitiesSkylinesAPIDOC/index.html

** Water (taken from TerrainManager.CountWaterCoverage) **
255 * number of cells of water
```
water += Mathf.Min(255, mHeight);
pollution += Mathf.Min(255, (int)cell.m_pollution);
num5++;
...
water = (water + (num5 >> 1)) / num5;
```
Natural resources is counted by number of cells with water having volume

Natural Resource Value
Oil > Ore > Farming > Forestry