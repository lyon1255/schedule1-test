using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A7 RID: 1447
	[Serializable]
	public class ProductItemInstance : QualityItemInstance
	{
		// Token: 0x06007E7F RID: 32383 RVA: 0x0021D358 File Offset: 0x0021B558
		// Note: this type is marked as 'beforefieldinit'.
		static ProductItemInstance()
		{
			Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr);
			ProductItemInstance.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, "PackagingID");
			ProductItemInstance.NativeFieldInfoPtr_packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, "packaging");
			ProductItemInstance.NativeMethodInfoPtr_get_AppliedPackaging_Public_get_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679116);
			ProductItemInstance.NativeMethodInfoPtr_get_Amount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679117);
			ProductItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679118);
			ProductItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_get_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679119);
			ProductItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_get_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679120);
			ProductItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679121);
			ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679122);
			ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679123);
			ProductItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679124);
			ProductItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679125);
			ProductItemInstance.NativeMethodInfoPtr_SetPackaging_Public_Virtual_New_Void_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679126);
			ProductItemInstance.NativeMethodInfoPtr_GetEquippable_Private_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679127);
			ProductItemInstance.NativeMethodInfoPtr_GetStoredItem_Private_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679128);
			ProductItemInstance.NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_New_Void_FilledPackagingVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679129);
			ProductItemInstance.NativeMethodInfoPtr_GetIcon_Private_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679130);
			ProductItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679131);
			ProductItemInstance.NativeMethodInfoPtr_GetAddictiveness_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679132);
			ProductItemInstance.NativeMethodInfoPtr_GetSimilarity_Public_Single_ProductDefinition_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679133);
			ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679134);
			ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679135);
			ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679136);
			ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679137);
			ProductItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679138);
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x06007E80 RID: 32384 RVA: 0x0021D57C File Offset: 0x0021B77C
		public unsafe PackagingDefinition AppliedPackaging
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 239149, RefRangeEnd = 239198, XrefRangeStart = 239122, XrefRangeEnd = 239149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_get_AppliedPackaging_Public_get_PackagingDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x06007E81 RID: 32385 RVA: 0x0021D5BC File Offset: 0x0021B7BC
		public unsafe int Amount
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 239204, RefRangeEnd = 239221, XrefRangeStart = 239198, XrefRangeEnd = 239204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_get_Amount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x06007E82 RID: 32386 RVA: 0x0021D5F8 File Offset: 0x0021B7F8
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239221, XrefRangeEnd = 239232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x06007E83 RID: 32387 RVA: 0x0021D63C File Offset: 0x0021B83C
		public unsafe override Equippable Equippable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239232, XrefRangeEnd = 239239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_get_Equippable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr3) : null;
			}
		}

		// Token: 0x1700264F RID: 9807
		// (get) Token: 0x06007E84 RID: 32388 RVA: 0x0021D688 File Offset: 0x0021B888
		public unsafe override StoredItem StoredItem
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239239, XrefRangeEnd = 239246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_get_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr3) : null;
			}
		}

		// Token: 0x17002650 RID: 9808
		// (get) Token: 0x06007E85 RID: 32389 RVA: 0x0021D6D4 File Offset: 0x0021B8D4
		public unsafe override Sprite Icon
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239246, XrefRangeEnd = 239258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x06007E86 RID: 32390 RVA: 0x0021D720 File Offset: 0x0021B920
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 238244, RefRangeEnd = 238249, XrefRangeStart = 238244, XrefRangeEnd = 238249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E87 RID: 32391 RVA: 0x0021D75C File Offset: 0x0021B95C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 239271, RefRangeEnd = 239283, XrefRangeStart = 239258, XrefRangeEnd = 239271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition _packaging = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_packaging);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E88 RID: 32392 RVA: 0x0021D7D8 File Offset: 0x0021B9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239283, XrefRangeEnd = 239306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkQuantities;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x0021D840 File Offset: 0x0021BA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239306, XrefRangeEnd = 239312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x0021D898 File Offset: 0x0021BA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239312, XrefRangeEnd = 239321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPackaging(PackagingDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_SetPackaging_Public_Virtual_New_Void_PackagingDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x0021D8E8 File Offset: 0x0021BAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable GetEquippable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetEquippable_Private_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr3) : null;
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x0021D928 File Offset: 0x0021BB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem GetStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetStoredItem_Private_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr3) : null;
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x0021D968 File Offset: 0x0021BB68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239323, RefRangeEnd = 239324, XrefRangeStart = 239321, XrefRangeEnd = 239323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visuals);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_New_Void_FilledPackagingVisuals_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E8E RID: 32398 RVA: 0x0021D9B8 File Offset: 0x0021BBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239324, XrefRangeEnd = 239336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GetIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetIcon_Private_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06007E8F RID: 32399 RVA: 0x0021D9F8 File Offset: 0x0021BBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239336, XrefRangeEnd = 239343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x06007E90 RID: 32400 RVA: 0x0021DA44 File Offset: 0x0021BC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239343, XrefRangeEnd = 239351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetAddictiveness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetAddictiveness_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007E91 RID: 32401 RVA: 0x0021DA8C File Offset: 0x0021BC8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239375, RefRangeEnd = 239376, XrefRangeStart = 239351, XrefRangeEnd = 239375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSimilarity(ProductDefinition other, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetSimilarity_Public_Single_ProductDefinition_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x0021DAE8 File Offset: 0x0021BCE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239414, RefRangeEnd = 239417, XrefRangeStart = 239376, XrefRangeEnd = 239414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyEffectsToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E93 RID: 32403 RVA: 0x0021DB38 File Offset: 0x0021BD38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239455, RefRangeEnd = 239458, XrefRangeStart = 239417, XrefRangeEnd = 239455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearEffectsFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E94 RID: 32404 RVA: 0x0021DB88 File Offset: 0x0021BD88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239496, RefRangeEnd = 239499, XrefRangeStart = 239458, XrefRangeEnd = 239496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyEffectsToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E95 RID: 32405 RVA: 0x0021DBD8 File Offset: 0x0021BDD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239537, RefRangeEnd = 239540, XrefRangeStart = 239499, XrefRangeEnd = 239537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearEffectsFromPlayer(Player Player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E96 RID: 32406 RVA: 0x0021DC28 File Offset: 0x0021BE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239540, XrefRangeEnd = 239548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007E97 RID: 32407 RVA: 0x0003C205 File Offset: 0x0003A405
		public ProductItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x06007E98 RID: 32408 RVA: 0x0021DC70 File Offset: 0x0021BE70
		// (set) Token: 0x06007E99 RID: 32409 RVA: 0x0003C20E File Offset: 0x0003A40E
		public unsafe string PackagingID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_PackagingID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x06007E9A RID: 32410 RVA: 0x0021DC98 File Offset: 0x0021BE98
		// (set) Token: 0x06007E9B RID: 32411 RVA: 0x0003C22D File Offset: 0x0003A42D
		public unsafe PackagingDefinition packaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_packaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005614 RID: 22036
		private static readonly IntPtr NativeFieldInfoPtr_PackagingID;

		// Token: 0x04005615 RID: 22037
		private static readonly IntPtr NativeFieldInfoPtr_packaging;

		// Token: 0x04005616 RID: 22038
		private static readonly IntPtr NativeMethodInfoPtr_get_AppliedPackaging_Public_get_PackagingDefinition_0;

		// Token: 0x04005617 RID: 22039
		private static readonly IntPtr NativeMethodInfoPtr_get_Amount_Public_get_Int32_0;

		// Token: 0x04005618 RID: 22040
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04005619 RID: 22041
		private static readonly IntPtr NativeMethodInfoPtr_get_Equippable_Public_Virtual_get_Equippable_0;

		// Token: 0x0400561A RID: 22042
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredItem_Public_Virtual_get_StoredItem_0;

		// Token: 0x0400561B RID: 22043
		private static readonly IntPtr NativeMethodInfoPtr_get_Icon_Public_Virtual_get_Sprite_0;

		// Token: 0x0400561C RID: 22044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400561D RID: 22045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0;

		// Token: 0x0400561E RID: 22046
		private static readonly IntPtr NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0;

		// Token: 0x0400561F RID: 22047
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005620 RID: 22048
		private static readonly IntPtr NativeMethodInfoPtr_SetPackaging_Public_Virtual_New_Void_PackagingDefinition_0;

		// Token: 0x04005621 RID: 22049
		private static readonly IntPtr NativeMethodInfoPtr_GetEquippable_Private_Equippable_0;

		// Token: 0x04005622 RID: 22050
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredItem_Private_StoredItem_0;

		// Token: 0x04005623 RID: 22051
		private static readonly IntPtr NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_New_Void_FilledPackagingVisuals_0;

		// Token: 0x04005624 RID: 22052
		private static readonly IntPtr NativeMethodInfoPtr_GetIcon_Private_Sprite_0;

		// Token: 0x04005625 RID: 22053
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x04005626 RID: 22054
		private static readonly IntPtr NativeMethodInfoPtr_GetAddictiveness_Public_Virtual_New_Single_0;

		// Token: 0x04005627 RID: 22055
		private static readonly IntPtr NativeMethodInfoPtr_GetSimilarity_Public_Single_ProductDefinition_EQuality_0;

		// Token: 0x04005628 RID: 22056
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_New_Void_NPC_0;

		// Token: 0x04005629 RID: 22057
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_New_Void_NPC_0;

		// Token: 0x0400562A RID: 22058
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400562B RID: 22059
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400562C RID: 22060
		private static readonly IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0;

		// Token: 0x02000ACB RID: 2763
		[ObfuscatedName("ScheduleOne.Product.ProductItemInstance+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D44C RID: 54348 RVA: 0x0032AA04 File Offset: 0x00328C04
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr);
				ProductItemInstance.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__26_0");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__27_0");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__28_0");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__29_0");
				ProductItemInstance.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679140);
				ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToNPC_b__26_0_Internal_Int32_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679141);
				ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromNPC_b__27_0_Internal_Int32_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679142);
				ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToPlayer_b__28_0_Internal_Int32_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679143);
				ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromPlayer_b__29_0_Internal_Int32_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679144);
			}

			// Token: 0x0600D44D RID: 54349 RVA: 0x0032AAF8 File Offset: 0x00328CF8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D44E RID: 54350 RVA: 0x0032AB34 File Offset: 0x00328D34
			[CallerCount(0)]
			public unsafe int _ApplyEffectsToNPC_b__26_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToNPC_b__26_0_Internal_Int32_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D44F RID: 54351 RVA: 0x0032AB84 File Offset: 0x00328D84
			[CallerCount(0)]
			public unsafe int _ClearEffectsFromNPC_b__27_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromNPC_b__27_0_Internal_Int32_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D450 RID: 54352 RVA: 0x0032ABD4 File Offset: 0x00328DD4
			[CallerCount(0)]
			public unsafe int _ApplyEffectsToPlayer_b__28_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToPlayer_b__28_0_Internal_Int32_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D451 RID: 54353 RVA: 0x0032AC24 File Offset: 0x00328E24
			[CallerCount(0)]
			public unsafe int _ClearEffectsFromPlayer_b__29_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromPlayer_b__29_0_Internal_Int32_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D452 RID: 54354 RVA: 0x0006753A File Offset: 0x0006573A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041CF RID: 16847
			// (get) Token: 0x0600D453 RID: 54355 RVA: 0x0032AC74 File Offset: 0x00328E74
			// (set) Token: 0x0600D454 RID: 54356 RVA: 0x00067543 File Offset: 0x00065743
			public unsafe static ProductItemInstance.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D0 RID: 16848
			// (get) Token: 0x0600D455 RID: 54357 RVA: 0x0032AC9C File Offset: 0x00328E9C
			// (set) Token: 0x0600D456 RID: 54358 RVA: 0x00067555 File Offset: 0x00065755
			public unsafe static Func<Property, int> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Property, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D1 RID: 16849
			// (get) Token: 0x0600D457 RID: 54359 RVA: 0x0032ACC4 File Offset: 0x00328EC4
			// (set) Token: 0x0600D458 RID: 54360 RVA: 0x00067567 File Offset: 0x00065767
			public unsafe static Func<Property, int> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Property, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D2 RID: 16850
			// (get) Token: 0x0600D459 RID: 54361 RVA: 0x0032ACEC File Offset: 0x00328EEC
			// (set) Token: 0x0600D45A RID: 54362 RVA: 0x00067579 File Offset: 0x00065779
			public unsafe static Func<Property, int> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Property, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D3 RID: 16851
			// (get) Token: 0x0600D45B RID: 54363 RVA: 0x0032AD14 File Offset: 0x00328F14
			// (set) Token: 0x0600D45C RID: 54364 RVA: 0x0006758B File Offset: 0x0006578B
			public unsafe static Func<Property, int> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Property, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EEC RID: 36588
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EED RID: 36589
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04008EEE RID: 36590
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04008EEF RID: 36591
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x04008EF0 RID: 36592
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x04008EF1 RID: 36593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EF2 RID: 36594
			private static readonly IntPtr NativeMethodInfoPtr__ApplyEffectsToNPC_b__26_0_Internal_Int32_Property_0;

			// Token: 0x04008EF3 RID: 36595
			private static readonly IntPtr NativeMethodInfoPtr__ClearEffectsFromNPC_b__27_0_Internal_Int32_Property_0;

			// Token: 0x04008EF4 RID: 36596
			private static readonly IntPtr NativeMethodInfoPtr__ApplyEffectsToPlayer_b__28_0_Internal_Int32_Property_0;

			// Token: 0x04008EF5 RID: 36597
			private static readonly IntPtr NativeMethodInfoPtr__ClearEffectsFromPlayer_b__29_0_Internal_Int32_Property_0;
		}
	}
}
