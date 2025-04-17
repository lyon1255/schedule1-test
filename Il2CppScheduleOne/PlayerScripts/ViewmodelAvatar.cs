using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003EB RID: 1003
	public class ViewmodelAvatar : Singleton<ViewmodelAvatar>
	{
		// Token: 0x06005240 RID: 21056 RVA: 0x00185984 File Offset: 0x00183B84
		// Note: this type is marked as 'beforefieldinit'.
		static ViewmodelAvatar()
		{
			Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "ViewmodelAvatar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr);
			ViewmodelAvatar.NativeFieldInfoPtr__IsVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "<IsVisible>k__BackingField");
			ViewmodelAvatar.NativeFieldInfoPtr_ParentAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "ParentAvatar");
			ViewmodelAvatar.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "Animator");
			ViewmodelAvatar.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "Avatar");
			ViewmodelAvatar.NativeFieldInfoPtr_RightHandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "RightHandContainer");
			ViewmodelAvatar.NativeFieldInfoPtr_baseOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, "baseOffset");
			ViewmodelAvatar.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673615);
			ViewmodelAvatar.NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673616);
			ViewmodelAvatar.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673617);
			ViewmodelAvatar.NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673618);
			ViewmodelAvatar.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673619);
			ViewmodelAvatar.NativeMethodInfoPtr_SetAnimatorController_Public_Void_RuntimeAnimatorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673620);
			ViewmodelAvatar.NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673621);
			ViewmodelAvatar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673622);
			ViewmodelAvatar.NativeMethodInfoPtr__Awake_b__9_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr, 100673623);
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x06005241 RID: 21057 RVA: 0x00185AE0 File Offset: 0x00183CE0
		// (set) Token: 0x06005242 RID: 21058 RVA: 0x00185B1C File Offset: 0x00183D1C
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x00185B5C File Offset: 0x00183D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177700, XrefRangeEnd = 177724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelAvatar.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x00185B98 File Offset: 0x00183D98
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 177731, RefRangeEnd = 177736, XrefRangeStart = 177724, XrefRangeEnd = 177731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisibility(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x00185BD8 File Offset: 0x00183DD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177764, RefRangeEnd = 177766, XrefRangeStart = 177736, XrefRangeEnd = 177764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppearance(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x00185C1C File Offset: 0x00183E1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177768, RefRangeEnd = 177770, XrefRangeStart = 177766, XrefRangeEnd = 177768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimatorController(RuntimeAnimatorController controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetAnimatorController_Public_Void_RuntimeAnimatorController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x00185C60 File Offset: 0x00183E60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177772, RefRangeEnd = 177774, XrefRangeStart = 177770, XrefRangeEnd = 177772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOffset(Vector3 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x00185CA0 File Offset: 0x00183EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177774, XrefRangeEnd = 177777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViewmodelAvatar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewmodelAvatar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x00185CDC File Offset: 0x00183EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177777, XrefRangeEnd = 177779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__9_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelAvatar.NativeMethodInfoPtr__Awake_b__9_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x00027208 File Offset: 0x00025408
		public ViewmodelAvatar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x0600524B RID: 21067 RVA: 0x00185D10 File Offset: 0x00183F10
		// (set) Token: 0x0600524C RID: 21068 RVA: 0x00027211 File Offset: 0x00025411
		public unsafe bool _IsVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr__IsVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr__IsVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x0600524D RID: 21069 RVA: 0x00185D38 File Offset: 0x00183F38
		// (set) Token: 0x0600524E RID: 21070 RVA: 0x0002722C File Offset: 0x0002542C
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar ParentAvatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_ParentAvatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_ParentAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x0600524F RID: 21071 RVA: 0x00185D68 File Offset: 0x00183F68
		// (set) Token: 0x06005250 RID: 21072 RVA: 0x0002724B File Offset: 0x0002544B
		public unsafe Animator Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x06005251 RID: 21073 RVA: 0x00185D98 File Offset: 0x00183F98
		// (set) Token: 0x06005252 RID: 21074 RVA: 0x0002726A File Offset: 0x0002546A
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06005253 RID: 21075 RVA: 0x00185DC8 File Offset: 0x00183FC8
		// (set) Token: 0x06005254 RID: 21076 RVA: 0x00027289 File Offset: 0x00025489
		public unsafe Transform RightHandContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_RightHandContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_RightHandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06005255 RID: 21077 RVA: 0x00185DF8 File Offset: 0x00183FF8
		// (set) Token: 0x06005256 RID: 21078 RVA: 0x000272A8 File Offset: 0x000254A8
		public unsafe Vector3 baseOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_baseOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelAvatar.NativeFieldInfoPtr_baseOffset)) = value;
			}
		}

		// Token: 0x040037CF RID: 14287
		private static readonly IntPtr NativeFieldInfoPtr__IsVisible_k__BackingField;

		// Token: 0x040037D0 RID: 14288
		private static readonly IntPtr NativeFieldInfoPtr_ParentAvatar;

		// Token: 0x040037D1 RID: 14289
		private static readonly IntPtr NativeFieldInfoPtr_Animator;

		// Token: 0x040037D2 RID: 14290
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x040037D3 RID: 14291
		private static readonly IntPtr NativeFieldInfoPtr_RightHandContainer;

		// Token: 0x040037D4 RID: 14292
		private static readonly IntPtr NativeFieldInfoPtr_baseOffset;

		// Token: 0x040037D5 RID: 14293
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x040037D6 RID: 14294
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0;

		// Token: 0x040037D7 RID: 14295
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040037D8 RID: 14296
		private static readonly IntPtr NativeMethodInfoPtr_SetVisibility_Public_Void_Boolean_0;

		// Token: 0x040037D9 RID: 14297
		private static readonly IntPtr NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0;

		// Token: 0x040037DA RID: 14298
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimatorController_Public_Void_RuntimeAnimatorController_0;

		// Token: 0x040037DB RID: 14299
		private static readonly IntPtr NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0;

		// Token: 0x040037DC RID: 14300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037DD RID: 14301
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__9_0_Private_Void_0;
	}
}
