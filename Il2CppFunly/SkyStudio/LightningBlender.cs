using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000EA RID: 234
	public class LightningBlender : FeatureBlender
	{
		// Token: 0x06001255 RID: 4693 RVA: 0x000AA224 File Offset: 0x000A8424
		// Note: this type is marked as 'beforefieldinit'.
		static LightningBlender()
		{
			Il2CppClassPointerStore<LightningBlender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LightningBlender");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningBlender>.NativeClassPtr);
			LightningBlender.NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBlender>.NativeClassPtr, 100665399);
			LightningBlender.NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBlender>.NativeClassPtr, 100665400);
			LightningBlender.NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBlender>.NativeClassPtr, 100665401);
			LightningBlender.NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBlender>.NativeClassPtr, 100665402);
			LightningBlender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBlender>.NativeClassPtr, 100665403);
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x000AA2B8 File Offset: 0x000A84B8
		public unsafe override string featureKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89390, XrefRangeEnd = 89392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningBlender.NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000AA2FC File Offset: 0x000A84FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89392, XrefRangeEnd = 89420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningBlender.NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x000AA360 File Offset: 0x000A8560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89420, XrefRangeEnd = 89424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningBlender.NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x000AA3C4 File Offset: 0x000A85C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89424, XrefRangeEnd = 89428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightningBlender.NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000AA428 File Offset: 0x000A8628
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningBlender() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningBlender>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningBlender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0000B1A5 File Offset: 0x000093A5
		public LightningBlender(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
