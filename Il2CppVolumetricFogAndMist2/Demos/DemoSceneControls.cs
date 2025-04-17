using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppVolumetricFogAndMist2.Demos
{
	// Token: 0x020000C1 RID: 193
	public class DemoSceneControls : MonoBehaviour
	{
		// Token: 0x06000E49 RID: 3657 RVA: 0x0009E4E8 File Offset: 0x0009C6E8
		// Note: this type is marked as 'beforefieldinit'.
		static DemoSceneControls()
		{
			Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VolumetricFogAndMist2.Demos", "DemoSceneControls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr);
			DemoSceneControls.NativeFieldInfoPtr_profiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, "profiles");
			DemoSceneControls.NativeFieldInfoPtr_fogVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, "fogVolume");
			DemoSceneControls.NativeFieldInfoPtr_presetNameDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, "presetNameDisplay");
			DemoSceneControls.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, "index");
			DemoSceneControls.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, 100665038);
			DemoSceneControls.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, 100665039);
			DemoSceneControls.NativeMethodInfoPtr_SetProfile_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, 100665040);
			DemoSceneControls.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr, 100665041);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0009E5B8 File Offset: 0x0009C7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85708, XrefRangeEnd = 85709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoSceneControls.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0009E5EC File Offset: 0x0009C7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85709, XrefRangeEnd = 85716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoSceneControls.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x0009E620 File Offset: 0x0009C820
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 85732, RefRangeEnd = 85734, XrefRangeStart = 85716, XrefRangeEnd = 85732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProfile(int profileIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref profileIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoSceneControls.NativeMethodInfoPtr_SetProfile_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0009E660 File Offset: 0x0009C860
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DemoSceneControls() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemoSceneControls>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoSceneControls.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00008E8E File Offset: 0x0000708E
		public DemoSceneControls(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0009E69C File Offset: 0x0009C89C
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00008E97 File Offset: 0x00007097
		public unsafe Il2CppReferenceArray<VolumetricFogProfile> profiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_profiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VolumetricFogProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_profiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0009E6CC File Offset: 0x0009C8CC
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00008EB6 File Offset: 0x000070B6
		public unsafe VolumetricFog fogVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_fogVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricFog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_fogVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0009E6FC File Offset: 0x0009C8FC
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00008ED5 File Offset: 0x000070D5
		public unsafe Text presetNameDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_presetNameDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_presetNameDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0009E72C File Offset: 0x0009C92C
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x00008EF4 File Offset: 0x000070F4
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoSceneControls.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeFieldInfoPtr_profiles;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeFieldInfoPtr_fogVolume;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeFieldInfoPtr_presetNameDisplay;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_SetProfile_Private_Void_Int32_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
