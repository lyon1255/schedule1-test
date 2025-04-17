using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D4 RID: 1492
	public class IDs : ItemFilter
	{
		// Token: 0x0600832C RID: 33580 RVA: 0x0022DFF0 File Offset: 0x0022C1F0
		// Note: this type is marked as 'beforefieldinit'.
		static IDs()
		{
			Il2CppClassPointerStore<IDs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IDs>.NativeClassPtr);
			IDs.NativeFieldInfoPtr_AcceptedIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IDs>.NativeClassPtr, "AcceptedIDs");
			IDs.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDs>.NativeClassPtr, 100679706);
			IDs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDs>.NativeClassPtr, 100679707);
		}

		// Token: 0x0600832D RID: 33581 RVA: 0x0022E05C File Offset: 0x0022C25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246960, XrefRangeEnd = 246963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDs.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600832E RID: 33582 RVA: 0x0022E0B4 File Offset: 0x0022C2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246963, XrefRangeEnd = 246971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDs() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IDs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IDs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600832F RID: 33583 RVA: 0x0003E560 File Offset: 0x0003C760
		public IDs(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x06008330 RID: 33584 RVA: 0x0022E0F0 File Offset: 0x0022C2F0
		// (set) Token: 0x06008331 RID: 33585 RVA: 0x0003E569 File Offset: 0x0003C769
		public unsafe List<string> AcceptedIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IDs.NativeFieldInfoPtr_AcceptedIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IDs.NativeFieldInfoPtr_AcceptedIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400594D RID: 22861
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedIDs;

		// Token: 0x0400594E RID: 22862
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;

		// Token: 0x0400594F RID: 22863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
