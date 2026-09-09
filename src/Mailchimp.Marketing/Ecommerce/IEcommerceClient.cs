using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

public partial interface IEcommerceClient
{
    /// <summary>
    /// Get information about the e-commerce endpoint's resources.
    /// </summary>
    WithRawResponseTask<ListEcommerceResponse> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about an account's orders.
    /// </summary>
    Task<Pager<ECommerceOrder>> ListOrdersAsync(
        ListOrdersEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about all stores in the account.
    /// </summary>
    Task<Pager<ECommerceStore>> ListStoresAsync(
        ListStoresEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new store to your Mailchimp account.
    /// </summary>
    WithRawResponseTask<ECommerceStore> CreateStoreAsync(
        CreateStoreEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific store.
    /// </summary>
    WithRawResponseTask<ECommerceStore> GetStoreAsync(
        GetStoreEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a store. Deleting a store will also delete any associated subresources, including Customers, Orders, Products, and Carts.
    /// </summary>
    WithRawResponseTask DeleteStoreAsync(
        DeleteStoreEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a store.
    /// </summary>
    WithRawResponseTask<ECommerceStore> UpdateStoreAsync(
        UpdateStoreEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a store's carts.
    /// </summary>
    Task<Pager<ECommerceCart>> ListStoreCartsAsync(
        ListStoreCartsEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new cart to a store.
    /// </summary>
    WithRawResponseTask<ECommerceCart> CreateStoreCartAsync(
        CreateStoreCartEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific cart.
    /// </summary>
    WithRawResponseTask<ECommerceCart> GetStoreCartAsync(
        GetStoreCartEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a cart.
    /// </summary>
    WithRawResponseTask DeleteStoreCartAsync(
        DeleteStoreCartEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific cart.
    /// </summary>
    WithRawResponseTask<ECommerceCart> UpdateStoreCartAsync(
        UpdateStoreCartEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a cart's line items.
    /// </summary>
    Task<Pager<ECommerceCartLineItem>> ListStoreCartLinesAsync(
        ListStoreCartLinesEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new line item to an existing cart.
    /// </summary>
    WithRawResponseTask<ECommerceCartLineItem> CreateStoreCartLineAsync(
        CreateStoreCartLineEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific cart line item.
    /// </summary>
    WithRawResponseTask<ECommerceCartLineItem> GetStoreCartLineAsync(
        GetStoreCartLineEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific cart line item.
    /// </summary>
    WithRawResponseTask DeleteStoreCartLineAsync(
        DeleteStoreCartLineEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific cart line item.
    /// </summary>
    WithRawResponseTask<ECommerceCartLineItem> UpdateStoreCartLineAsync(
        UpdateStoreCartLineEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a store's customers.
    /// </summary>
    Task<Pager<ECommerceCustomer>> ListStoreCustomersAsync(
        ListStoreCustomersEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new customer to a store.
    /// </summary>
    WithRawResponseTask<ECommerceCustomer> CreateStoreCustomerAsync(
        CreateStoreCustomerEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific customer.
    /// </summary>
    WithRawResponseTask<ECommerceCustomer> GetStoreCustomerAsync(
        GetStoreCustomerEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add or update a customer.
    /// </summary>
    WithRawResponseTask<ECommerceCustomer> UpsertStoreCustomerAsync(
        UpsertStoreCustomerEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a customer from a store.
    /// </summary>
    WithRawResponseTask DeleteStoreCustomerAsync(
        DeleteStoreCustomerEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a customer.
    /// </summary>
    WithRawResponseTask<ECommerceCustomer> UpdateStoreCustomerAsync(
        UpdateStoreCustomerEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a store's orders.
    /// </summary>
    Task<Pager<ECommerceOrder>> ListStoreOrdersAsync(
        ListStoreOrdersEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new order to a store.
    /// </summary>
    WithRawResponseTask<ECommerceOrder> CreateStoreOrderAsync(
        CreateStoreOrderEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific order.
    /// </summary>
    WithRawResponseTask<ECommerceOrder> GetStoreOrderAsync(
        GetStoreOrderEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete an order.
    /// </summary>
    WithRawResponseTask DeleteStoreOrderAsync(
        DeleteStoreOrderEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific order.
    /// </summary>
    WithRawResponseTask<ECommerceOrder> UpdateStoreOrderAsync(
        UpdateStoreOrderEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about an order's line items.
    /// </summary>
    Task<Pager<ECommerceOrderLineItem>> ListStoreOrderLinesAsync(
        ListStoreOrderLinesEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new line item to an existing order.
    /// </summary>
    WithRawResponseTask<ECommerceOrderLineItem> CreateStoreOrderLineAsync(
        CreateStoreOrderLineEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific order line item.
    /// </summary>
    WithRawResponseTask<ECommerceOrderLineItem> GetStoreOrderLineAsync(
        GetStoreOrderLineEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a specific order line item.
    /// </summary>
    WithRawResponseTask DeleteStoreOrderLineAsync(
        DeleteStoreOrderLineEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific order line item.
    /// </summary>
    WithRawResponseTask<ECommerceOrderLineItem> UpdateStoreOrderLineAsync(
        UpdateStoreOrderLineEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a store's products.
    /// </summary>
    Task<Pager<ECommerceProduct>> ListStoreProductsAsync(
        ListStoreProductsEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new product to a store.
    /// </summary>
    WithRawResponseTask<ECommerceProduct> CreateStoreProductAsync(
        CreateStoreProductEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific product.
    /// </summary>
    WithRawResponseTask<ECommerceProduct> GetStoreProductAsync(
        GetStoreProductEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific product.
    /// </summary>
    WithRawResponseTask<ECommerceProduct> UpsertStoreProductAsync(
        UpsertStoreProductEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a product.
    /// </summary>
    WithRawResponseTask DeleteStoreProductAsync(
        DeleteStoreProductEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific product.
    /// </summary>
    WithRawResponseTask<ECommerceProduct> UpdateStoreProductAsync(
        UpdateStoreProductEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a product's images.
    /// </summary>
    Task<Pager<ListStoreProductImagesEcommerceResponseImagesItem>> ListStoreProductImagesAsync(
        ListStoreProductImagesEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new image to the product.
    /// </summary>
    WithRawResponseTask<CreateStoreProductImageEcommerceResponse> CreateStoreProductImageAsync(
        CreateStoreProductImageEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific product image.
    /// </summary>
    WithRawResponseTask<GetStoreProductImageEcommerceResponse> GetStoreProductImageAsync(
        GetStoreProductImageEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a product image.
    /// </summary>
    WithRawResponseTask DeleteStoreProductImageAsync(
        DeleteStoreProductImageEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a product image.
    /// </summary>
    WithRawResponseTask<UpdateStoreProductImageEcommerceResponse> UpdateStoreProductImageAsync(
        UpdateStoreProductImageEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a product's variants.
    /// </summary>
    Task<Pager<ECommerceProductVariant>> ListStoreProductVariantsAsync(
        ListStoreProductVariantsEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new variant to the product.
    /// </summary>
    WithRawResponseTask<ECommerceProductVariant> CreateStoreProductVariantAsync(
        CreateStoreProductVariantEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific product variant.
    /// </summary>
    WithRawResponseTask<ECommerceProductVariant> GetStoreProductVariantAsync(
        GetStoreProductVariantEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add or update a product variant.
    /// </summary>
    WithRawResponseTask<ECommerceProductVariant> UpsertStoreProductVariantAsync(
        UpsertStoreProductVariantEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a product variant.
    /// </summary>
    WithRawResponseTask DeleteStoreProductVariantAsync(
        DeleteStoreProductVariantEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a product variant.
    /// </summary>
    WithRawResponseTask<ECommerceProductVariant> UpdateStoreProductVariantAsync(
        UpdateStoreProductVariantEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a store's promo rules.
    /// </summary>
    Task<Pager<ECommercePromoRule>> ListStorePromoRulesAsync(
        ListStorePromoRulesEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new promo rule to a store.
    /// </summary>
    WithRawResponseTask<ECommercePromoRule> CreateStorePromoRuleAsync(
        CreateStorePromoRuleEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific promo rule.
    /// </summary>
    WithRawResponseTask<ECommercePromoRule> GetStorePromoRuleAsync(
        GetStorePromoRuleEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a promo rule from a store.
    /// </summary>
    WithRawResponseTask DeleteStorePromoRuleAsync(
        DeleteStorePromoRuleEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a promo rule.
    /// </summary>
    WithRawResponseTask<ECommercePromoRule> UpdateStorePromoRuleAsync(
        UpdateStorePromoRuleEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a store's promo codes.
    /// </summary>
    Task<Pager<ECommercePromoCode>> ListStorePromoRulePromoCodesAsync(
        ListStorePromoRulePromoCodesEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a new promo code to a store.
    /// </summary>
    WithRawResponseTask<ECommercePromoCode> CreateStorePromoRulePromoCodeAsync(
        CreateStorePromoRulePromoCodeEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific promo code.
    /// </summary>
    WithRawResponseTask<ECommercePromoCode> GetStorePromoRulePromoCodeAsync(
        GetStorePromoRulePromoCodeEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a promo code from a store.
    /// </summary>
    WithRawResponseTask DeleteStorePromoRulePromoCodeAsync(
        DeleteStorePromoRulePromoCodeEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a promo code.
    /// </summary>
    WithRawResponseTask<ECommercePromoCode> UpdateStorePromoRulePromoCodeAsync(
        UpdateStorePromoRulePromoCodeEcommerceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
