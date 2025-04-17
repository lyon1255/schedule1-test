using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x0200075B RID: 1883
	[Serializable]
	public class WateringCanDefinition : StorableItemDefinition
	{
		// Token: 0x0600B333 RID: 45875 RVA: 0x002CB39C File Offset: 0x002C959C
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanDefinition()
		{
			Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "WateringCanDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr);
			WateringCanDefinition.NativeFieldInfoPtr_Capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr, "Capacity");
			WateringCanDefinition.NativeFieldInfoPtr_FunctionalWateringCanPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr, "FunctionalWateringCanPrefab");
			WateringCanDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr, 100685402);
			WateringCanDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr, 100685403);
		}

		// Token: 0x0600B334 RID: 45876 RVA: 0x002CB41C File Offset: 0x002C961C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308366, XrefRangeEnd = 308370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WateringCanDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600B335 RID: 45877 RVA: 0x002CB474 File Offset: 0x002C9674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B336 RID: 45878 RVA: 0x00057CDD File Offset: 0x00055EDD
		public WateringCanDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x0600B337 RID: 45879 RVA: 0x002CB4B0 File Offset: 0x002C96B0
		// (set) Token: 0x0600B338 RID: 45880 RVA: 0x00057CE6 File Offset: 0x00055EE6
		public unsafe static float Capacity
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WateringCanDefinition.NativeFieldInfoPtr_Capacity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WateringCanDefinition.NativeFieldInfoPtr_Capacity, (void*)(&value));
			}
		}

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x0600B339 RID: 45881 RVA: 0x002CB4CC File Offset: 0x002C96CC
		// (set) Token: 0x0600B33A RID: 45882 RVA: 0x00057CF4 File Offset: 0x00055EF4
		public unsafe GameObject FunctionalWateringCanPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanDefinition.NativeFieldInfoPtr_FunctionalWateringCanPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanDefinition.NativeFieldInfoPtr_FunctionalWateringCanPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040078E8 RID: 30952
		private static readonly IntPtr NativeFieldInfoPtr_Capacity;

		// Token: 0x040078E9 RID: 30953
		private static readonly IntPtr NativeFieldInfoPtr_FunctionalWateringCanPrefab;

		// Token: 0x040078EA RID: 30954
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040078EB RID: 30955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
