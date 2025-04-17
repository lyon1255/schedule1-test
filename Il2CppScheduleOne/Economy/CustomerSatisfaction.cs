using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000416 RID: 1046
	public class CustomerSatisfaction : Object
	{
		// Token: 0x06005BA2 RID: 23458 RVA: 0x001A8F80 File Offset: 0x001A7180
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerSatisfaction()
		{
			Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "CustomerSatisfaction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr);
			CustomerSatisfaction.NativeMethodInfoPtr_GetRelationshipChange_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr, 100674981);
			CustomerSatisfaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr, 100674982);
		}

		// Token: 0x06005BA3 RID: 23459 RVA: 0x001A8FD8 File Offset: 0x001A71D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193357, RefRangeEnd = 193358, XrefRangeStart = 193357, XrefRangeEnd = 193357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetRelationshipChange(float satisfaction)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref satisfaction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSatisfaction.NativeMethodInfoPtr_GetRelationshipChange_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005BA4 RID: 23460 RVA: 0x001A9018 File Offset: 0x001A7218
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerSatisfaction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSatisfaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BA5 RID: 23461 RVA: 0x0002B398 File Offset: 0x00029598
		public CustomerSatisfaction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003EA7 RID: 16039
		private static readonly IntPtr NativeMethodInfoPtr_GetRelationshipChange_Public_Static_Single_Single_0;

		// Token: 0x04003EA8 RID: 16040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
