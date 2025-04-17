using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000ED RID: 237
	public class RainSplashBlender : FeatureBlender
	{
		// Token: 0x0600126A RID: 4714 RVA: 0x000AA8E4 File Offset: 0x000A8AE4
		// Note: this type is marked as 'beforefieldinit'.
		static RainSplashBlender()
		{
			Il2CppClassPointerStore<RainSplashBlender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RainSplashBlender");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainSplashBlender>.NativeClassPtr);
			RainSplashBlender.NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashBlender>.NativeClassPtr, 100665414);
			RainSplashBlender.NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashBlender>.NativeClassPtr, 100665415);
			RainSplashBlender.NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashBlender>.NativeClassPtr, 100665416);
			RainSplashBlender.NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashBlender>.NativeClassPtr, 100665417);
			RainSplashBlender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashBlender>.NativeClassPtr, 100665418);
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x000AA978 File Offset: 0x000A8B78
		public unsafe override string featureKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89547, XrefRangeEnd = 89549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashBlender.NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x000AA9BC File Offset: 0x000A8BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89549, XrefRangeEnd = 89588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashBlender.NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x000AAA20 File Offset: 0x000A8C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89588, XrefRangeEnd = 89596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashBlender.NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000AAA84 File Offset: 0x000A8C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89596, XrefRangeEnd = 89604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashBlender.NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x000AAAE8 File Offset: 0x000A8CE8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RainSplashBlender() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainSplashBlender>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashBlender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0000B1C0 File Offset: 0x000093C0
		public RainSplashBlender(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
