using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x020005FB RID: 1531
	public class AvatarImpostor : MonoBehaviour
	{
		// Token: 0x060086F8 RID: 34552 RVA: 0x0023A814 File Offset: 0x00238A14
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarImpostor()
		{
			Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Impostors", "AvatarImpostor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr);
			AvatarImpostor.NativeFieldInfoPtr__HasTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, "<HasTexture>k__BackingField");
			AvatarImpostor.NativeFieldInfoPtr_meshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, "meshRenderer");
			AvatarImpostor.NativeFieldInfoPtr_cachedCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, "cachedCamera");
			AvatarImpostor.NativeMethodInfoPtr_get_HasTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680150);
			AvatarImpostor.NativeMethodInfoPtr_set_HasTexture_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680151);
			AvatarImpostor.NativeMethodInfoPtr_get_Camera_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680152);
			AvatarImpostor.NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680153);
			AvatarImpostor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680154);
			AvatarImpostor.NativeMethodInfoPtr_Realign_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680155);
			AvatarImpostor.NativeMethodInfoPtr_EnableImpostor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680156);
			AvatarImpostor.NativeMethodInfoPtr_DisableImpostor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680157);
			AvatarImpostor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100680158);
		}

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x060086F9 RID: 34553 RVA: 0x0023A934 File Offset: 0x00238B34
		// (set) Token: 0x060086FA RID: 34554 RVA: 0x0023A970 File Offset: 0x00238B70
		public unsafe bool HasTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_get_HasTexture_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_set_HasTexture_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002909 RID: 10505
		// (get) Token: 0x060086FB RID: 34555 RVA: 0x0023A9B0 File Offset: 0x00238BB0
		public unsafe Transform Camera
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 251077, RefRangeEnd = 251079, XrefRangeStart = 251066, XrefRangeEnd = 251077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_get_Camera_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060086FC RID: 34556 RVA: 0x0023A9F0 File Offset: 0x00238BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251079, XrefRangeEnd = 251085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAvatarSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086FD RID: 34557 RVA: 0x0023AA34 File Offset: 0x00238C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251085, XrefRangeEnd = 251086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086FE RID: 34558 RVA: 0x0023AA68 File Offset: 0x00238C68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 251100, RefRangeEnd = 251103, XrefRangeStart = 251086, XrefRangeEnd = 251100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Realign()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_Realign_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086FF RID: 34559 RVA: 0x0023AA9C File Offset: 0x00238C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251103, XrefRangeEnd = 251107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableImpostor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_EnableImpostor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008700 RID: 34560 RVA: 0x0023AAD0 File Offset: 0x00238CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194676, RefRangeEnd = 194677, XrefRangeStart = 194676, XrefRangeEnd = 194677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableImpostor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_DisableImpostor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008701 RID: 34561 RVA: 0x0023AB04 File Offset: 0x00238D04
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarImpostor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008702 RID: 34562 RVA: 0x0004036C File Offset: 0x0003E56C
		public AvatarImpostor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002905 RID: 10501
		// (get) Token: 0x06008703 RID: 34563 RVA: 0x0023AB40 File Offset: 0x00238D40
		// (set) Token: 0x06008704 RID: 34564 RVA: 0x00040375 File Offset: 0x0003E575
		public unsafe bool _HasTexture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr__HasTexture_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr__HasTexture_k__BackingField)) = value;
			}
		}

		// Token: 0x17002906 RID: 10502
		// (get) Token: 0x06008705 RID: 34565 RVA: 0x0023AB68 File Offset: 0x00238D68
		// (set) Token: 0x06008706 RID: 34566 RVA: 0x00040390 File Offset: 0x0003E590
		public unsafe MeshRenderer meshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_meshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_meshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002907 RID: 10503
		// (get) Token: 0x06008707 RID: 34567 RVA: 0x0023AB98 File Offset: 0x00238D98
		// (set) Token: 0x06008708 RID: 34568 RVA: 0x000403AF File Offset: 0x0003E5AF
		public unsafe Transform cachedCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_cachedCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_cachedCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BD7 RID: 23511
		private static readonly IntPtr NativeFieldInfoPtr__HasTexture_k__BackingField;

		// Token: 0x04005BD8 RID: 23512
		private static readonly IntPtr NativeFieldInfoPtr_meshRenderer;

		// Token: 0x04005BD9 RID: 23513
		private static readonly IntPtr NativeFieldInfoPtr_cachedCamera;

		// Token: 0x04005BDA RID: 23514
		private static readonly IntPtr NativeMethodInfoPtr_get_HasTexture_Public_get_Boolean_0;

		// Token: 0x04005BDB RID: 23515
		private static readonly IntPtr NativeMethodInfoPtr_set_HasTexture_Private_set_Void_Boolean_0;

		// Token: 0x04005BDC RID: 23516
		private static readonly IntPtr NativeMethodInfoPtr_get_Camera_Private_get_Transform_0;

		// Token: 0x04005BDD RID: 23517
		private static readonly IntPtr NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005BDE RID: 23518
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005BDF RID: 23519
		private static readonly IntPtr NativeMethodInfoPtr_Realign_Private_Void_0;

		// Token: 0x04005BE0 RID: 23520
		private static readonly IntPtr NativeMethodInfoPtr_EnableImpostor_Public_Void_0;

		// Token: 0x04005BE1 RID: 23521
		private static readonly IntPtr NativeMethodInfoPtr_DisableImpostor_Public_Void_0;

		// Token: 0x04005BE2 RID: 23522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
