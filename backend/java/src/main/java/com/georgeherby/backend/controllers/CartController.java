package com.georgeherby.backend.controllers;

import com.georgeherby.backend.models.ItemsResponse;
import com.georgeherby.backend.services.CartService;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class CartController {

  final CartService cartService;

  public CartController(CartService cartService) {
    this.cartService = cartService;
  }

  @GetMapping(path = "/items", produces = "application/json")
  public ResponseEntity<ItemsResponse> getShopItems() {
    return ResponseEntity.ok(
        new ItemsResponse(cartService.getProducts())
    );
  }

  @PostMapping("/total")
  public double getTotalPrice(@RequestBody String[] items) {
    throw new RuntimeException("Not implemented");
  }
}
