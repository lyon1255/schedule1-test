using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E8 RID: 1512
	public class ItemRemover : MonoBehaviour
	{
		// Token: 0x060083FF RID: 33791 RVA: 0x00230B84 File Offset: 0x0022ED84
		// Note: this type is marked as 'beforefieldinit'.
		static ItemRemover()
		{
			Il2CppClassPointerStore<ItemRemover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemRemover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr);
			ItemRemover.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, "Item");
			ItemRemover.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, "Quantity");
			ItemRemover.NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, 100679800);
			ItemRemover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, 100679801);
		}

		// Token: 0x06008400 RID: 33792 RVA: 0x00230C04 File Offset: 0x0022EE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247696, XrefRangeEnd = 247702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemRemover.NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008401 RID: 33793 RVA: 0x00230C38 File Offset: 0x0022EE38
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemRemover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemRemover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008402 RID: 33794 RVA: 0x0003EAC5 File Offset: 0x0003CCC5
		public ItemRemover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x06008403 RID: 33795 RVA: 0x00230C74 File Offset: 0x0022EE74
		// (set) Token: 0x06008404 RID: 33796 RVA: 0x0003EACE File Offset: 0x0003CCCE
		public unsafe ItemDefinition Item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x06008405 RID: 33797 RVA: 0x00230CA4 File Offset: 0x0022EEA4
		// (set) Token: 0x06008406 RID: 33798 RVA: 0x0003EAED File Offset: 0x0003CCED
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x040059D9 RID: 23001
		private static readonly IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x040059DA RID: 23002
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x040059DB RID: 23003
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

		// Token: 0x040059DC RID: 23004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
