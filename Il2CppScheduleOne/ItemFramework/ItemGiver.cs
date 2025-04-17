using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E3 RID: 1507
	public class ItemGiver : MonoBehaviour
	{
		// Token: 0x0600839D RID: 33693 RVA: 0x0022F7AC File Offset: 0x0022D9AC
		// Note: this type is marked as 'beforefieldinit'.
		static ItemGiver()
		{
			Il2CppClassPointerStore<ItemGiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemGiver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr);
			ItemGiver.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, "Item");
			ItemGiver.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, "Quantity");
			ItemGiver.NativeMethodInfoPtr_Give_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, 100679750);
			ItemGiver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, 100679751);
		}

		// Token: 0x0600839E RID: 33694 RVA: 0x0022F82C File Offset: 0x0022DA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247205, XrefRangeEnd = 247211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Give()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemGiver.NativeMethodInfoPtr_Give_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600839F RID: 33695 RVA: 0x0022F860 File Offset: 0x0022DA60
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemGiver() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemGiver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083A0 RID: 33696 RVA: 0x0003E84F File Offset: 0x0003CA4F
		public ItemGiver(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x060083A1 RID: 33697 RVA: 0x0022F89C File Offset: 0x0022DA9C
		// (set) Token: 0x060083A2 RID: 33698 RVA: 0x0003E858 File Offset: 0x0003CA58
		public unsafe ItemDefinition Item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x060083A3 RID: 33699 RVA: 0x0022F8CC File Offset: 0x0022DACC
		// (set) Token: 0x060083A4 RID: 33700 RVA: 0x0003E877 File Offset: 0x0003CA77
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x04005992 RID: 22930
		private static readonly IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x04005993 RID: 22931
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04005994 RID: 22932
		private static readonly IntPtr NativeMethodInfoPtr_Give_Public_Void_0;

		// Token: 0x04005995 RID: 22933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
