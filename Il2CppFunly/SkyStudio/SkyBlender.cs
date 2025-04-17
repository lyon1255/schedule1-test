using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000EE RID: 238
	public class SkyBlender : FeatureBlender
	{
		// Token: 0x06001271 RID: 4721 RVA: 0x000AAB24 File Offset: 0x000A8D24
		// Note: this type is marked as 'beforefieldinit'.
		static SkyBlender()
		{
			Il2CppClassPointerStore<SkyBlender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SkyBlender");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyBlender>.NativeClassPtr);
			SkyBlender.NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBlender>.NativeClassPtr, 100665419);
			SkyBlender.NativeMethodInfoPtr_BlendingMode_Protected_Virtual_ProfileFeatureBlendingMode_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBlender>.NativeClassPtr, 100665420);
			SkyBlender.NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBlender>.NativeClassPtr, 100665421);
			SkyBlender.NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBlender>.NativeClassPtr, 100665422);
			SkyBlender.NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBlender>.NativeClassPtr, 100665423);
			SkyBlender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBlender>.NativeClassPtr, 100665424);
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x000AABCC File Offset: 0x000A8DCC
		public unsafe override string featureKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89604, XrefRangeEnd = 89606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkyBlender.NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x000AAC10 File Offset: 0x000A8E10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76499, RefRangeEnd = 76503, XrefRangeStart = 76499, XrefRangeEnd = 76503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ProfileFeatureBlendingMode BlendingMode(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkyBlender.NativeMethodInfoPtr_BlendingMode_Protected_Virtual_ProfileFeatureBlendingMode_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x000AAC80 File Offset: 0x000A8E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89606, XrefRangeEnd = 89655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkyBlender.NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000AACE4 File Offset: 0x000A8EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89655, XrefRangeEnd = 89665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkyBlender.NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x000AAD48 File Offset: 0x000A8F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89665, XrefRangeEnd = 89675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkyBlender.NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x000AADAC File Offset: 0x000A8FAC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkyBlender() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyBlender>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyBlender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0000B1C9 File Offset: 0x000093C9
		public SkyBlender(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_BlendingMode_Protected_Virtual_ProfileFeatureBlendingMode_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
