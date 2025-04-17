using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E7 RID: 1511
	public static class ItemQuality : Il2CppSystem.Object
	{
		// Token: 0x060083E9 RID: 33769 RVA: 0x002308FC File Offset: 0x0022EAFC
		// Note: this type is marked as 'beforefieldinit'.
		static ItemQuality()
		{
			Il2CppClassPointerStore<ItemQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemQuality");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr);
			ItemQuality.NativeFieldInfoPtr_Heavenly_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Heavenly_Threshold");
			ItemQuality.NativeFieldInfoPtr_Premium_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Premium_Threshold");
			ItemQuality.NativeFieldInfoPtr_Standard_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Standard_Threshold");
			ItemQuality.NativeFieldInfoPtr_Poor_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Poor_Threshold");
			ItemQuality.NativeFieldInfoPtr_Heavenly_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Heavenly_Color");
			ItemQuality.NativeFieldInfoPtr_Premium_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Premium_Color");
			ItemQuality.NativeFieldInfoPtr_Standard_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Standard_Color");
			ItemQuality.NativeFieldInfoPtr_Poor_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Poor_Color");
			ItemQuality.NativeFieldInfoPtr_Trash_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Trash_Color");
			ItemQuality.NativeMethodInfoPtr_GetQuality_Public_Static_EQuality_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, 100679797);
			ItemQuality.NativeMethodInfoPtr_GetColor_Public_Static_Color_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, 100679798);
		}

		// Token: 0x060083EA RID: 33770 RVA: 0x00230A08 File Offset: 0x0022EC08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247681, RefRangeEnd = 247683, XrefRangeStart = 247681, XrefRangeEnd = 247681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuality GetQuality(float qualityScalar)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref qualityScalar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemQuality.NativeMethodInfoPtr_GetQuality_Public_Static_EQuality_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060083EB RID: 33771 RVA: 0x00230A48 File Offset: 0x0022EC48
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 247690, RefRangeEnd = 247696, XrefRangeStart = 247683, XrefRangeEnd = 247690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(EQuality quality)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemQuality.NativeMethodInfoPtr_GetColor_Public_Static_Color_EQuality_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060083EC RID: 33772 RVA: 0x0003EA3E File Offset: 0x0003CC3E
		public ItemQuality(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x060083ED RID: 33773 RVA: 0x00230A88 File Offset: 0x0022EC88
		// (set) Token: 0x060083EE RID: 33774 RVA: 0x0003EA47 File Offset: 0x0003CC47
		public unsafe static float Heavenly_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x060083EF RID: 33775 RVA: 0x00230AA4 File Offset: 0x0022ECA4
		// (set) Token: 0x060083F0 RID: 33776 RVA: 0x0003EA55 File Offset: 0x0003CC55
		public unsafe static float Premium_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Premium_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Premium_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x060083F1 RID: 33777 RVA: 0x00230AC0 File Offset: 0x0022ECC0
		// (set) Token: 0x060083F2 RID: 33778 RVA: 0x0003EA63 File Offset: 0x0003CC63
		public unsafe static float Standard_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Standard_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Standard_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x060083F3 RID: 33779 RVA: 0x00230ADC File Offset: 0x0022ECDC
		// (set) Token: 0x060083F4 RID: 33780 RVA: 0x0003EA71 File Offset: 0x0003CC71
		public unsafe static float Poor_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Poor_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Poor_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x060083F5 RID: 33781 RVA: 0x00230AF8 File Offset: 0x0022ECF8
		// (set) Token: 0x060083F6 RID: 33782 RVA: 0x0003EA7F File Offset: 0x0003CC7F
		public unsafe static Color Heavenly_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Color, (void*)(&value));
			}
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x060083F7 RID: 33783 RVA: 0x00230B14 File Offset: 0x0022ED14
		// (set) Token: 0x060083F8 RID: 33784 RVA: 0x0003EA8D File Offset: 0x0003CC8D
		public unsafe static Color Premium_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Premium_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Premium_Color, (void*)(&value));
			}
		}

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x060083F9 RID: 33785 RVA: 0x00230B30 File Offset: 0x0022ED30
		// (set) Token: 0x060083FA RID: 33786 RVA: 0x0003EA9B File Offset: 0x0003CC9B
		public unsafe static Color Standard_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Standard_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Standard_Color, (void*)(&value));
			}
		}

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x060083FB RID: 33787 RVA: 0x00230B4C File Offset: 0x0022ED4C
		// (set) Token: 0x060083FC RID: 33788 RVA: 0x0003EAA9 File Offset: 0x0003CCA9
		public unsafe static Color Poor_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Poor_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Poor_Color, (void*)(&value));
			}
		}

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x060083FD RID: 33789 RVA: 0x00230B68 File Offset: 0x0022ED68
		// (set) Token: 0x060083FE RID: 33790 RVA: 0x0003EAB7 File Offset: 0x0003CCB7
		public unsafe static Color Trash_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Trash_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Trash_Color, (void*)(&value));
			}
		}

		// Token: 0x040059CE RID: 22990
		private static readonly IntPtr NativeFieldInfoPtr_Heavenly_Threshold;

		// Token: 0x040059CF RID: 22991
		private static readonly IntPtr NativeFieldInfoPtr_Premium_Threshold;

		// Token: 0x040059D0 RID: 22992
		private static readonly IntPtr NativeFieldInfoPtr_Standard_Threshold;

		// Token: 0x040059D1 RID: 22993
		private static readonly IntPtr NativeFieldInfoPtr_Poor_Threshold;

		// Token: 0x040059D2 RID: 22994
		private static readonly IntPtr NativeFieldInfoPtr_Heavenly_Color;

		// Token: 0x040059D3 RID: 22995
		private static readonly IntPtr NativeFieldInfoPtr_Premium_Color;

		// Token: 0x040059D4 RID: 22996
		private static readonly IntPtr NativeFieldInfoPtr_Standard_Color;

		// Token: 0x040059D5 RID: 22997
		private static readonly IntPtr NativeFieldInfoPtr_Poor_Color;

		// Token: 0x040059D6 RID: 22998
		private static readonly IntPtr NativeFieldInfoPtr_Trash_Color;

		// Token: 0x040059D7 RID: 22999
		private static readonly IntPtr NativeMethodInfoPtr_GetQuality_Public_Static_EQuality_Single_0;

		// Token: 0x040059D8 RID: 23000
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_EQuality_0;
	}
}
