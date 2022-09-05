package com.georgeherby.backend.services;

import com.georgeherby.backend.models.Product;
import org.springframework.stereotype.Service;

import java.util.ArrayList;

@Service
public class CartService {

  ArrayList<Product> products = new ArrayList<>();

  public CartService() {
    products.add(new Product("Apple", 60));
    products.add(new Product("Orange", 25));
  }

  public ArrayList<Product> getProducts(){
    return products;
  }
}
