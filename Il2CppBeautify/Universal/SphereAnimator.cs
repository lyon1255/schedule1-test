using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppBeautify.Universal
{
	// Token: 0x0200013E RID: 318
	public class SphereAnimator : MonoBehaviour
	{
		// Token: 0x06001A73 RID: 6771 RVA: 0x000C3230 File Offset: 0x000C1430
		// Note: this type is marked as 'beforefieldinit'.
		static SphereAnimator()
		{
			Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Universal", "SphereAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr);
			SphereAnimator.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr, "rb");
			SphereAnimator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr, 100666102);
			SphereAnimator.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr, 100666103);
			SphereAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr, 100666104);
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x000C32B0 File Offset: 0x000C14B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97205, XrefRangeEnd = 97209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereAnimator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x000C32E4 File Offset: 0x000C14E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97209, XrefRangeEnd = 97217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereAnimator.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x000C3318 File Offset: 0x000C1518
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SphereAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SphereAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0000EFD6 File Offset: 0x0000D1D6
		public SphereAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x000C3354 File Offset: 0x000C1554
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0000EFDF File Offset: 0x0000D1DF
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereAnimator.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereAnimator.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
