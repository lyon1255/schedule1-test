using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200070D RID: 1805
	public class ShopColorPicker : MonoBehaviour
	{
		// Token: 0x0600A223 RID: 41507 RVA: 0x0028BFA0 File Offset: 0x0028A1A0
		// Note: this type is marked as 'beforefieldinit'.
		static ShopColorPicker()
		{
			Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr);
			ShopColorPicker.NativeFieldInfoPtr_AssetIconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "AssetIconImage");
			ShopColorPicker.NativeFieldInfoPtr_ColorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "ColorLabel");
			ShopColorPicker.NativeFieldInfoPtr_ColorButtonParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "ColorButtonParent");
			ShopColorPicker.NativeFieldInfoPtr_ColorButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "ColorButtonPrefab");
			ShopColorPicker.NativeFieldInfoPtr_onColorPicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "onColorPicked");
			ShopColorPicker.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683125);
			ShopColorPicker.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683126);
			ShopColorPicker.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683127);
			ShopColorPicker.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683128);
			ShopColorPicker.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683129);
			ShopColorPicker.NativeMethodInfoPtr_ColorHovered_Private_Void_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683130);
			ShopColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, 100683131);
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600A224 RID: 41508 RVA: 0x0028C0C0 File Offset: 0x0028A2C0
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A225 RID: 41509 RVA: 0x0028C0FC File Offset: 0x0028A2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284215, XrefRangeEnd = 284294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A226 RID: 41510 RVA: 0x0028C130 File Offset: 0x0028A330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284294, XrefRangeEnd = 284300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorPicked(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A227 RID: 41511 RVA: 0x0028C170 File Offset: 0x0028A370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284300, XrefRangeEnd = 284305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A228 RID: 41512 RVA: 0x0028C1B4 File Offset: 0x0028A3B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194676, RefRangeEnd = 194677, XrefRangeStart = 194676, XrefRangeEnd = 194677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A229 RID: 41513 RVA: 0x0028C1E8 File Offset: 0x0028A3E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284308, RefRangeEnd = 284310, XrefRangeStart = 284305, XrefRangeEnd = 284308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorHovered(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr_ColorHovered_Private_Void_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A22A RID: 41514 RVA: 0x0028C228 File Offset: 0x0028A428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284310, XrefRangeEnd = 284318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A22B RID: 41515 RVA: 0x0004FC7C File Offset: 0x0004DE7C
		public ShopColorPicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600A22C RID: 41516 RVA: 0x0028C264 File Offset: 0x0028A464
		// (set) Token: 0x0600A22D RID: 41517 RVA: 0x0004FC85 File Offset: 0x0004DE85
		public unsafe Image AssetIconImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_AssetIconImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_AssetIconImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600A22E RID: 41518 RVA: 0x0028C294 File Offset: 0x0028A494
		// (set) Token: 0x0600A22F RID: 41519 RVA: 0x0004FCA4 File Offset: 0x0004DEA4
		public unsafe TextMeshProUGUI ColorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600A230 RID: 41520 RVA: 0x0028C2C4 File Offset: 0x0028A4C4
		// (set) Token: 0x0600A231 RID: 41521 RVA: 0x0004FCC3 File Offset: 0x0004DEC3
		public unsafe RectTransform ColorButtonParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600A232 RID: 41522 RVA: 0x0028C2F4 File Offset: 0x0028A4F4
		// (set) Token: 0x0600A233 RID: 41523 RVA: 0x0004FCE2 File Offset: 0x0004DEE2
		public unsafe GameObject ColorButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_ColorButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600A234 RID: 41524 RVA: 0x0028C324 File Offset: 0x0028A524
		// (set) Token: 0x0600A235 RID: 41525 RVA: 0x0004FD01 File Offset: 0x0004DF01
		public unsafe UnityEvent<EClothingColor> onColorPicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_onColorPicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EClothingColor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.NativeFieldInfoPtr_onColorPicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006CC3 RID: 27843
		private static readonly IntPtr NativeFieldInfoPtr_AssetIconImage;

		// Token: 0x04006CC4 RID: 27844
		private static readonly IntPtr NativeFieldInfoPtr_ColorLabel;

		// Token: 0x04006CC5 RID: 27845
		private static readonly IntPtr NativeFieldInfoPtr_ColorButtonParent;

		// Token: 0x04006CC6 RID: 27846
		private static readonly IntPtr NativeFieldInfoPtr_ColorButtonPrefab;

		// Token: 0x04006CC7 RID: 27847
		private static readonly IntPtr NativeFieldInfoPtr_onColorPicked;

		// Token: 0x04006CC8 RID: 27848
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006CC9 RID: 27849
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04006CCA RID: 27850
		private static readonly IntPtr NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0;

		// Token: 0x04006CCB RID: 27851
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_0;

		// Token: 0x04006CCC RID: 27852
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006CCD RID: 27853
		private static readonly IntPtr NativeMethodInfoPtr_ColorHovered_Private_Void_EClothingColor_0;

		// Token: 0x04006CCE RID: 27854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BB4 RID: 2996
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopColorPicker+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD38 RID: 56632 RVA: 0x003440CC File Offset: 0x003422CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopColorPicker>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr);
				ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, "color");
				ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, 100683132);
				ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, 100683133);
				ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr, 100683134);
			}

			// Token: 0x0600DD39 RID: 56633 RVA: 0x0034415C File Offset: 0x0034235C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopColorPicker.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD3A RID: 56634 RVA: 0x00344198 File Offset: 0x00342398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284207, XrefRangeEnd = 284213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD3B RID: 56635 RVA: 0x003441CC File Offset: 0x003423CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284213, XrefRangeEnd = 284215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopColorPicker.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD3C RID: 56636 RVA: 0x0006BD16 File Offset: 0x00069F16
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004491 RID: 17553
			// (get) Token: 0x0600DD3D RID: 56637 RVA: 0x00344210 File Offset: 0x00342410
			// (set) Token: 0x0600DD3E RID: 56638 RVA: 0x0006BD1F File Offset: 0x00069F1F
			public unsafe EClothingColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17004492 RID: 17554
			// (get) Token: 0x0600DD3F RID: 56639 RVA: 0x00344238 File Offset: 0x00342438
			// (set) Token: 0x0600DD40 RID: 56640 RVA: 0x0006BD3A File Offset: 0x00069F3A
			public unsafe ShopColorPicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopColorPicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopColorPicker.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009432 RID: 37938
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04009433 RID: 37939
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009434 RID: 37940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009435 RID: 37941
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;

			// Token: 0x04009436 RID: 37942
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Void_BaseEventData_0;
		}
	}
}
