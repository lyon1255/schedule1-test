using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppRadiantGI.Universal
{
	// Token: 0x020000C6 RID: 198
	public class ToggleEffect : MonoBehaviour
	{
		// Token: 0x06000EC2 RID: 3778 RVA: 0x0009F628 File Offset: 0x0009D828
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleEffect()
		{
			Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RadiantGI.Universal", "ToggleEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr);
			ToggleEffect.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr, "profile");
			ToggleEffect.NativeFieldInfoPtr_radiant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr, "radiant");
			ToggleEffect.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr, 100665055);
			ToggleEffect.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr, 100665056);
			ToggleEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr, 100665057);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0009F6BC File Offset: 0x0009D8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85916, XrefRangeEnd = 85920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleEffect.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0009F6F0 File Offset: 0x0009D8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85920, XrefRangeEnd = 85921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleEffect.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0009F724 File Offset: 0x0009D924
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleEffect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000093D8 File Offset: 0x000075D8
		public ToggleEffect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0009F760 File Offset: 0x0009D960
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x000093E1 File Offset: 0x000075E1
		public unsafe VolumeProfile profile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleEffect.NativeFieldInfoPtr_profile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleEffect.NativeFieldInfoPtr_profile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0009F790 File Offset: 0x0009D990
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x00009400 File Offset: 0x00007600
		public unsafe RadiantGlobalIllumination radiant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleEffect.NativeFieldInfoPtr_radiant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RadiantGlobalIllumination>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleEffect.NativeFieldInfoPtr_radiant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeFieldInfoPtr_profile;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeFieldInfoPtr_radiant;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
