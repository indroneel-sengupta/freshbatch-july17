import { Pipe, PipeTransform } from '@angular/core';
import{Adv} from '../Components/AdvertisementFormComponent/AdvertisementFormComponent.component'
@Pipe({name: 'search'}) 


export class FilterPipe implements PipeTransform{
    transform(products:Array<Adv>, search_text:string){
        console.log("search text value : ",search_text);
        let newProducts:Array<Adv>=[];

        if(search_text==="") {return products;}

        console.log("oldProducts : ", products);
        console.log("newProducts : ", newProducts);
        products.forEach(function(product){
            if(product.name.toLowerCase().includes(search_text)){
                newProducts.push(product);
            }
        })
        console.log(newProducts)
        return newProducts;
    }
}


