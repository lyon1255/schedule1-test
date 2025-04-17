using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000586 RID: 1414
	public class CookableModule : ItemModule
	{
		// Token: 0x06007C8B RID: 31883 RVA: 0x00217238 File Offset: 0x00215438
		// Note: this type is marked as 'beforefieldinit'.
		static CookableModule()
		{
			Il2CppClassPointerStore<CookableModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "CookableModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookableModule>.NativeClassPtr);
			CookableModule.NativeFieldInfoPtr_CookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "CookTime");
			CookableModule.NativeFieldInfoPtr_CookType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "CookType");
			CookableModule.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "Product");
			CookableModule.NativeFieldInfoPtr_ProductQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "ProductQuantity");
			CookableModule.NativeFieldInfoPtr_ProductShardPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "ProductShardPrefab");
			CookableModule.NativeFieldInfoPtr_LiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "LiquidColor");
			CookableModule.NativeFieldInfoPtr_SolidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "SolidColor");
			CookableModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, 100678898);
		}

		// Token: 0x06007C8C RID: 31884 RVA: 0x00217308 File Offset: 0x00215508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237257, XrefRangeEnd = 237258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookableModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookableModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookableModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x0003B1BD File Offset: 0x000393BD
		public CookableModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x06007C8E RID: 31886 RVA: 0x00217344 File Offset: 0x00215544
		// (set) Token: 0x06007C8F RID: 31887 RVA: 0x0003B1C6 File Offset: 0x000393C6
		public unsafe int CookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookTime)) = value;
			}
		}

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x06007C90 RID: 31888 RVA: 0x0021736C File Offset: 0x0021556C
		// (set) Token: 0x06007C91 RID: 31889 RVA: 0x0003B1E1 File Offset: 0x000393E1
		public unsafe CookableModule.ECookableType CookType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookType)) = value;
			}
		}

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x06007C92 RID: 31890 RVA: 0x00217394 File Offset: 0x00215594
		// (set) Token: 0x06007C93 RID: 31891 RVA: 0x0003B1FC File Offset: 0x000393FC
		public unsafe StorableItemDefinition Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x06007C94 RID: 31892 RVA: 0x002173C4 File Offset: 0x002155C4
		// (set) Token: 0x06007C95 RID: 31893 RVA: 0x0003B21B File Offset: 0x0003941B
		public unsafe int ProductQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductQuantity)) = value;
			}
		}

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x06007C96 RID: 31894 RVA: 0x002173EC File Offset: 0x002155EC
		// (set) Token: 0x06007C97 RID: 31895 RVA: 0x0003B236 File Offset: 0x00039436
		public unsafe Rigidbody ProductShardPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductShardPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductShardPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x06007C98 RID: 31896 RVA: 0x0021741C File Offset: 0x0021561C
		// (set) Token: 0x06007C99 RID: 31897 RVA: 0x0003B255 File Offset: 0x00039455
		public unsafe Color LiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_LiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_LiquidColor)) = value;
			}
		}

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x06007C9A RID: 31898 RVA: 0x00217444 File Offset: 0x00215644
		// (set) Token: 0x06007C9B RID: 31899 RVA: 0x0003B270 File Offset: 0x00039470
		public unsafe Color SolidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_SolidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_SolidColor)) = value;
			}
		}

		// Token: 0x040054CB RID: 21707
		private static readonly IntPtr NativeFieldInfoPtr_CookTime;

		// Token: 0x040054CC RID: 21708
		private static readonly IntPtr NativeFieldInfoPtr_CookType;

		// Token: 0x040054CD RID: 21709
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x040054CE RID: 21710
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuantity;

		// Token: 0x040054CF RID: 21711
		private static readonly IntPtr NativeFieldInfoPtr_ProductShardPrefab;

		// Token: 0x040054D0 RID: 21712
		private static readonly IntPtr NativeFieldInfoPtr_LiquidColor;

		// Token: 0x040054D1 RID: 21713
		private static readonly IntPtr NativeFieldInfoPtr_SolidColor;

		// Token: 0x040054D2 RID: 21714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AB4 RID: 2740
		[OriginalName("Assembly-CSharp.dll", "", "ECookableType")]
		public enum ECookableType
		{
			// Token: 0x04008E93 RID: 36499
			Liquid,
			// Token: 0x04008E94 RID: 36500
			Solid
		}
	}
}
