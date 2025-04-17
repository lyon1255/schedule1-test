using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D9 RID: 1497
	public class ItemFilter_ID : ItemFilter
	{
		// Token: 0x06008349 RID: 33609 RVA: 0x0022E668 File Offset: 0x0022C868
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_ID()
		{
			Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_ID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr);
			ItemFilter_ID.NativeFieldInfoPtr_IsWhitelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, "IsWhitelist");
			ItemFilter_ID.NativeFieldInfoPtr_IDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, "IDs");
			ItemFilter_ID.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, 100679719);
			ItemFilter_ID.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, 100679720);
		}

		// Token: 0x0600834A RID: 33610 RVA: 0x0022E6E8 File Offset: 0x0022C8E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 247029, RefRangeEnd = 247034, XrefRangeStart = 247020, XrefRangeEnd = 247029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_ID(List<string> ids) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ID.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600834B RID: 33611 RVA: 0x0022E734 File Offset: 0x0022C934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247034, XrefRangeEnd = 247037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_ID.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600834C RID: 33612 RVA: 0x0003E5E6 File Offset: 0x0003C7E6
		public ItemFilter_ID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x0600834D RID: 33613 RVA: 0x0022E78C File Offset: 0x0022C98C
		// (set) Token: 0x0600834E RID: 33614 RVA: 0x0003E5EF File Offset: 0x0003C7EF
		public unsafe bool IsWhitelist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IsWhitelist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IsWhitelist)) = value;
			}
		}

		// Token: 0x170027B9 RID: 10169
		// (get) Token: 0x0600834F RID: 33615 RVA: 0x0022E7B4 File Offset: 0x0022C9B4
		// (set) Token: 0x06008350 RID: 33616 RVA: 0x0003E60A File Offset: 0x0003C80A
		public unsafe List<string> IDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400595D RID: 22877
		private static readonly IntPtr NativeFieldInfoPtr_IsWhitelist;

		// Token: 0x0400595E RID: 22878
		private static readonly IntPtr NativeFieldInfoPtr_IDs;

		// Token: 0x0400595F RID: 22879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;

		// Token: 0x04005960 RID: 22880
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
