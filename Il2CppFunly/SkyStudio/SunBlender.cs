using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F0 RID: 240
	public class SunBlender : FeatureBlender
	{
		// Token: 0x06001283 RID: 4739 RVA: 0x000AB0C0 File Offset: 0x000A92C0
		// Note: this type is marked as 'beforefieldinit'.
		static SunBlender()
		{
			Il2CppClassPointerStore<SunBlender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SunBlender");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SunBlender>.NativeClassPtr);
			SunBlender.NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBlender>.NativeClassPtr, 100665431);
			SunBlender.NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBlender>.NativeClassPtr, 100665432);
			SunBlender.NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBlender>.NativeClassPtr, 100665433);
			SunBlender.NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBlender>.NativeClassPtr, 100665434);
			SunBlender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBlender>.NativeClassPtr, 100665435);
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x000AB154 File Offset: 0x000A9354
		public unsafe override string featureKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89793, XrefRangeEnd = 89795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SunBlender.NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x000AB198 File Offset: 0x000A9398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89795, XrefRangeEnd = 89830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SunBlender.NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x000AB1FC File Offset: 0x000A93FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89830, XrefRangeEnd = 89838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SunBlender.NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x000AB260 File Offset: 0x000A9460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89838, XrefRangeEnd = 89846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SunBlender.NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x000AB2C4 File Offset: 0x000A94C4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SunBlender() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SunBlender>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunBlender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0000B1F6 File Offset: 0x000093F6
		public SunBlender(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
