using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000082 RID: 130
	public class EffectFromProfile : MonoBehaviour
	{
		// Token: 0x0600097A RID: 2426 RVA: 0x0008D894 File Offset: 0x0008BA94
		// Note: this type is marked as 'beforefieldinit'.
		static EffectFromProfile()
		{
			Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "EffectFromProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr);
			EffectFromProfile.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, "ClassName");
			EffectFromProfile.NativeFieldInfoPtr_m_EffectProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, "m_EffectProfile");
			EffectFromProfile.NativeFieldInfoPtr_m_EffectInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, "m_EffectInstance");
			EffectFromProfile.NativeMethodInfoPtr_get_effectProfile_Public_get_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100664319);
			EffectFromProfile.NativeMethodInfoPtr_set_effectProfile_Public_set_Void_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100664320);
			EffectFromProfile.NativeMethodInfoPtr_InitInstanceFromProfile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100664321);
			EffectFromProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100664322);
			EffectFromProfile.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100664323);
			EffectFromProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100664324);
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x0008D978 File Offset: 0x0008BB78
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x0008D9B8 File Offset: 0x0008BBB8
		public unsafe EffectAbstractBase effectProfile
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_get_effectProfile_Public_get_EffectAbstractBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EffectAbstractBase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80201, XrefRangeEnd = 80203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_set_effectProfile_Public_set_Void_EffectAbstractBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0008D9FC File Offset: 0x0008BBFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80211, RefRangeEnd = 80213, XrefRangeStart = 80203, XrefRangeEnd = 80211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitInstanceFromProfile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_InitInstanceFromProfile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0008DA30 File Offset: 0x0008BC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80213, XrefRangeEnd = 80231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0008DA64 File Offset: 0x0008BC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80231, XrefRangeEnd = 80236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0008DA98 File Offset: 0x0008BC98
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectFromProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00007230 File Offset: 0x00005430
		public EffectFromProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0008DAD4 File Offset: 0x0008BCD4
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00007239 File Offset: 0x00005439
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectFromProfile.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectFromProfile.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0008DAF4 File Offset: 0x0008BCF4
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x0000724B File Offset: 0x0000544B
		public unsafe EffectAbstractBase m_EffectProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFromProfile.NativeFieldInfoPtr_m_EffectProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFromProfile.NativeFieldInfoPtr_m_EffectProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x0008DB24 File Offset: 0x0008BD24
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x0000726A File Offset: 0x0000546A
		public unsafe EffectAbstractBase m_EffectInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFromProfile.NativeFieldInfoPtr_m_EffectInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFromProfile.NativeFieldInfoPtr_m_EffectInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectProfile;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectInstance;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_get_effectProfile_Public_get_EffectAbstractBase_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_set_effectProfile_Public_set_Void_EffectAbstractBase_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_InitInstanceFromProfile_Public_Void_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
