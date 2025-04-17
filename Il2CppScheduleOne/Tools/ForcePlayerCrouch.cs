using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200053A RID: 1338
	public class ForcePlayerCrouch : MonoBehaviour
	{
		// Token: 0x060076E3 RID: 30435 RVA: 0x00204758 File Offset: 0x00202958
		// Note: this type is marked as 'beforefieldinit'.
		static ForcePlayerCrouch()
		{
			Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ForcePlayerCrouch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr);
			ForcePlayerCrouch.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr, 100678278);
			ForcePlayerCrouch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr, 100678279);
		}

		// Token: 0x060076E4 RID: 30436 RVA: 0x002047B0 File Offset: 0x002029B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231192, XrefRangeEnd = 231212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForcePlayerCrouch.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x002047F4 File Offset: 0x002029F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForcePlayerCrouch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForcePlayerCrouch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x0003850A File Offset: 0x0003670A
		public ForcePlayerCrouch(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400512D RID: 20781
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x0400512E RID: 20782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
