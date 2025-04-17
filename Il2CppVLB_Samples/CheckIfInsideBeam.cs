using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB_Samples
{
	// Token: 0x020000BB RID: 187
	public class CheckIfInsideBeam : MonoBehaviour
	{
		// Token: 0x06000DFB RID: 3579 RVA: 0x0009D8AC File Offset: 0x0009BAAC
		// Note: this type is marked as 'beforefieldinit'.
		static CheckIfInsideBeam()
		{
			Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "CheckIfInsideBeam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr);
			CheckIfInsideBeam.NativeFieldInfoPtr_isInsideBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, "isInsideBeam");
			CheckIfInsideBeam.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, "m_Material");
			CheckIfInsideBeam.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, "m_Collider");
			CheckIfInsideBeam.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, 100665020);
			CheckIfInsideBeam.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, 100665021);
			CheckIfInsideBeam.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, 100665022);
			CheckIfInsideBeam.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, 100665023);
			CheckIfInsideBeam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, 100665024);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0009D97C File Offset: 0x0009BB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85482, XrefRangeEnd = 85495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckIfInsideBeam.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0009D9B0 File Offset: 0x0009BBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85495, XrefRangeEnd = 85503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckIfInsideBeam.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0009D9E4 File Offset: 0x0009BBE4
		[CallerCount(0)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckIfInsideBeam.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0009DA18 File Offset: 0x0009BC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85503, XrefRangeEnd = 85510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckIfInsideBeam.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0009DA5C File Offset: 0x0009BC5C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckIfInsideBeam() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckIfInsideBeam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00008BC4 File Offset: 0x00006DC4
		public CheckIfInsideBeam(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0009DA98 File Offset: 0x0009BC98
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x00008BCD File Offset: 0x00006DCD
		public unsafe bool isInsideBeam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckIfInsideBeam.NativeFieldInfoPtr_isInsideBeam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckIfInsideBeam.NativeFieldInfoPtr_isInsideBeam)) = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x0009DAC0 File Offset: 0x0009BCC0
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x00008BE8 File Offset: 0x00006DE8
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckIfInsideBeam.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckIfInsideBeam.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x0009DAF0 File Offset: 0x0009BCF0
		// (set) Token: 0x06000E07 RID: 3591 RVA: 0x00008C07 File Offset: 0x00006E07
		public unsafe Collider m_Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckIfInsideBeam.NativeFieldInfoPtr_m_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckIfInsideBeam.NativeFieldInfoPtr_m_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeFieldInfoPtr_isInsideBeam;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
