using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A6 RID: 1446
	public class ProductIconManager : Singleton<ProductIconManager>
	{
		// Token: 0x06007E6F RID: 32367 RVA: 0x0021D02C File Offset: 0x0021B22C
		// Note: this type is marked as 'beforefieldinit'.
		static ProductIconManager()
		{
			Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductIconManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr);
			ProductIconManager.NativeFieldInfoPtr_icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "icons");
			ProductIconManager.NativeFieldInfoPtr_IconGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "IconGenerator");
			ProductIconManager.NativeFieldInfoPtr_IconContainerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "IconContainerPath");
			ProductIconManager.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "Products");
			ProductIconManager.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "Packaging");
			ProductIconManager.NativeMethodInfoPtr_GetIcon_Public_Sprite_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679107);
			ProductIconManager.NativeMethodInfoPtr_GenerateIcons_Public_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679108);
			ProductIconManager.NativeMethodInfoPtr_GenerateProductTexture_Private_Texture2D_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679109);
			ProductIconManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679110);
		}

		// Token: 0x06007E70 RID: 32368 RVA: 0x0021D110 File Offset: 0x0021B310
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 239068, RefRangeEnd = 239070, XrefRangeStart = 239048, XrefRangeEnd = 239068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GetIcon(string productID, string packagingID, bool ignoreError = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr_GetIcon_Public_Sprite_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06007E71 RID: 32369 RVA: 0x0021D180 File Offset: 0x0021B380
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239103, RefRangeEnd = 239106, XrefRangeStart = 239070, XrefRangeEnd = 239103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GenerateIcons(string productID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr_GenerateIcons_Public_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06007E72 RID: 32370 RVA: 0x0021D1D0 File Offset: 0x0021B3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239106, XrefRangeEnd = 239108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GenerateProductTexture(string productID, string packagingID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr_GenerateProductTexture_Private_Texture2D_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06007E73 RID: 32371 RVA: 0x0021D234 File Offset: 0x0021B434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239108, XrefRangeEnd = 239122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductIconManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E74 RID: 32372 RVA: 0x0003C161 File Offset: 0x0003A361
		public ProductIconManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x06007E75 RID: 32373 RVA: 0x0021D270 File Offset: 0x0021B470
		// (set) Token: 0x06007E76 RID: 32374 RVA: 0x0003C16A File Offset: 0x0003A36A
		public unsafe List<ProductIconManager.ProductIcon> icons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_icons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductIconManager.ProductIcon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_icons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x06007E77 RID: 32375 RVA: 0x0021D2A0 File Offset: 0x0021B4A0
		// (set) Token: 0x06007E78 RID: 32376 RVA: 0x0003C189 File Offset: 0x0003A389
		public unsafe IconGenerator IconGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x06007E79 RID: 32377 RVA: 0x0021D2D0 File Offset: 0x0021B4D0
		// (set) Token: 0x06007E7A RID: 32378 RVA: 0x0003C1A8 File Offset: 0x0003A3A8
		public unsafe string IconContainerPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconContainerPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconContainerPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x06007E7B RID: 32379 RVA: 0x0021D2F8 File Offset: 0x0021B4F8
		// (set) Token: 0x06007E7C RID: 32380 RVA: 0x0003C1C7 File Offset: 0x0003A3C7
		public unsafe Il2CppReferenceArray<ProductDefinition> Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x06007E7D RID: 32381 RVA: 0x0021D328 File Offset: 0x0021B528
		// (set) Token: 0x06007E7E RID: 32382 RVA: 0x0003C1E6 File Offset: 0x0003A3E6
		public unsafe Il2CppReferenceArray<PackagingDefinition> Packaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Packaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PackagingDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400560B RID: 22027
		private static readonly IntPtr NativeFieldInfoPtr_icons;

		// Token: 0x0400560C RID: 22028
		private static readonly IntPtr NativeFieldInfoPtr_IconGenerator;

		// Token: 0x0400560D RID: 22029
		private static readonly IntPtr NativeFieldInfoPtr_IconContainerPath;

		// Token: 0x0400560E RID: 22030
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x0400560F RID: 22031
		private static readonly IntPtr NativeFieldInfoPtr_Packaging;

		// Token: 0x04005610 RID: 22032
		private static readonly IntPtr NativeMethodInfoPtr_GetIcon_Public_Sprite_String_String_Boolean_0;

		// Token: 0x04005611 RID: 22033
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIcons_Public_Sprite_String_0;

		// Token: 0x04005612 RID: 22034
		private static readonly IntPtr NativeMethodInfoPtr_GenerateProductTexture_Private_Texture2D_String_String_0;

		// Token: 0x04005613 RID: 22035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC8 RID: 2760
		[Serializable]
		public class ProductIcon : Il2CppSystem.Object
		{
			// Token: 0x0600D435 RID: 54325 RVA: 0x0032A658 File Offset: 0x00328858
			// Note: this type is marked as 'beforefieldinit'.
			static ProductIcon()
			{
				Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "ProductIcon");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr);
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "ProductID");
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "PackagingID");
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "Icon");
				ProductIconManager.ProductIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, 100679111);
			}

			// Token: 0x0600D436 RID: 54326 RVA: 0x0032A6D4 File Offset: 0x003288D4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductIcon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.ProductIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D437 RID: 54327 RVA: 0x00067465 File Offset: 0x00065665
			public ProductIcon(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C9 RID: 16841
			// (get) Token: 0x0600D438 RID: 54328 RVA: 0x0032A710 File Offset: 0x00328910
			// (set) Token: 0x0600D439 RID: 54329 RVA: 0x0006746E File Offset: 0x0006566E
			public unsafe string ProductID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_ProductID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041CA RID: 16842
			// (get) Token: 0x0600D43A RID: 54330 RVA: 0x0032A738 File Offset: 0x00328938
			// (set) Token: 0x0600D43B RID: 54331 RVA: 0x0006748D File Offset: 0x0006568D
			public unsafe string PackagingID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_PackagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041CB RID: 16843
			// (get) Token: 0x0600D43C RID: 54332 RVA: 0x0032A760 File Offset: 0x00328960
			// (set) Token: 0x0600D43D RID: 54333 RVA: 0x000674AC File Offset: 0x000656AC
			public unsafe Sprite Icon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_Icon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EE1 RID: 36577
			private static readonly IntPtr NativeFieldInfoPtr_ProductID;

			// Token: 0x04008EE2 RID: 36578
			private static readonly IntPtr NativeFieldInfoPtr_PackagingID;

			// Token: 0x04008EE3 RID: 36579
			private static readonly IntPtr NativeFieldInfoPtr_Icon;

			// Token: 0x04008EE4 RID: 36580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AC9 RID: 2761
		[ObfuscatedName("ScheduleOne.Product.ProductIconManager+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D43E RID: 54334 RVA: 0x0032A790 File Offset: 0x00328990
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr);
				ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_productID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr, "productID");
				ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_packagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr, "packagingID");
				ProductIconManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr, 100679112);
				ProductIconManager.__c__DisplayClass6_0.NativeMethodInfoPtr__GetIcon_b__0_Internal_Boolean_ProductIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr, 100679113);
			}

			// Token: 0x0600D43F RID: 54335 RVA: 0x0032A80C File Offset: 0x00328A0C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D440 RID: 54336 RVA: 0x0032A848 File Offset: 0x00328A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239047, XrefRangeEnd = 239048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetIcon_b__0(ProductIconManager.ProductIcon x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass6_0.NativeMethodInfoPtr__GetIcon_b__0_Internal_Boolean_ProductIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D441 RID: 54337 RVA: 0x000674CB File Offset: 0x000656CB
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041CC RID: 16844
			// (get) Token: 0x0600D442 RID: 54338 RVA: 0x0032A898 File Offset: 0x00328A98
			// (set) Token: 0x0600D443 RID: 54339 RVA: 0x000674D4 File Offset: 0x000656D4
			public unsafe string productID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_productID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_productID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041CD RID: 16845
			// (get) Token: 0x0600D444 RID: 54340 RVA: 0x0032A8C0 File Offset: 0x00328AC0
			// (set) Token: 0x0600D445 RID: 54341 RVA: 0x000674F3 File Offset: 0x000656F3
			public unsafe string packagingID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_packagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_packagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EE5 RID: 36581
			private static readonly IntPtr NativeFieldInfoPtr_productID;

			// Token: 0x04008EE6 RID: 36582
			private static readonly IntPtr NativeFieldInfoPtr_packagingID;

			// Token: 0x04008EE7 RID: 36583
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EE8 RID: 36584
			private static readonly IntPtr NativeMethodInfoPtr__GetIcon_b__0_Internal_Boolean_ProductIcon_0;
		}

		// Token: 0x02000ACA RID: 2762
		[ObfuscatedName("ScheduleOne.Product.ProductIconManager+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D446 RID: 54342 RVA: 0x0032A8E8 File Offset: 0x00328AE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr);
				ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_productID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, "productID");
				ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, 100679114);
				ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__GenerateIcons_b__0_Internal_Boolean_ProductIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, 100679115);
			}

			// Token: 0x0600D447 RID: 54343 RVA: 0x0032A950 File Offset: 0x00328B50
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D448 RID: 54344 RVA: 0x0032A98C File Offset: 0x00328B8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateIcons_b__0(ProductIconManager.ProductIcon x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__GenerateIcons_b__0_Internal_Boolean_ProductIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D449 RID: 54345 RVA: 0x00067512 File Offset: 0x00065712
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041CE RID: 16846
			// (get) Token: 0x0600D44A RID: 54346 RVA: 0x0032A9DC File Offset: 0x00328BDC
			// (set) Token: 0x0600D44B RID: 54347 RVA: 0x0006751B File Offset: 0x0006571B
			public unsafe string productID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_productID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_productID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EE9 RID: 36585
			private static readonly IntPtr NativeFieldInfoPtr_productID;

			// Token: 0x04008EEA RID: 36586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EEB RID: 36587
			private static readonly IntPtr NativeMethodInfoPtr__GenerateIcons_b__0_Internal_Boolean_ProductIcon_0;
		}
	}
}
