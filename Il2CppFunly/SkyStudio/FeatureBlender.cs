using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F2 RID: 242
	public class FeatureBlender : MonoBehaviour
	{
		// Token: 0x060012C3 RID: 4803 RVA: 0x000ABD24 File Offset: 0x000A9F24
		// Note: this type is marked as 'beforefieldinit'.
		static FeatureBlender()
		{
			Il2CppClassPointerStore<FeatureBlender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "FeatureBlender");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeatureBlender>.NativeClassPtr);
			FeatureBlender.NativeMethodInfoPtr_get_featureKey_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureBlender>.NativeClassPtr, 100665449);
			FeatureBlender.NativeMethodInfoPtr_BlendBoth_Protected_Abstract_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureBlender>.NativeClassPtr, 100665450);
			FeatureBlender.NativeMethodInfoPtr_BlendIn_Protected_Abstract_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureBlender>.NativeClassPtr, 100665451);
			FeatureBlender.NativeMethodInfoPtr_BlendOut_Protected_Abstract_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureBlender>.NativeClassPtr, 100665452);
			FeatureBlender.NativeMethodInfoPtr_BlendingMode_Protected_Virtual_New_ProfileFeatureBlendingMode_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureBlender>.NativeClassPtr, 100665453);
			FeatureBlender.NativeMethodInfoPtr_Blend_Public_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureBlender>.NativeClassPtr, 100665454);
			FeatureBlender.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureBlender>.NativeClassPtr, 100665455);
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x000ABDE0 File Offset: 0x000A9FE0
		public unsafe virtual string featureKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeatureBlender.NativeMethodInfoPtr_get_featureKey_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x000ABE24 File Offset: 0x000AA024
		[CallerCount(0)]
		public unsafe virtual void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeatureBlender.NativeMethodInfoPtr_BlendBoth_Protected_Abstract_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x000ABE88 File Offset: 0x000AA088
		[CallerCount(0)]
		public unsafe virtual void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeatureBlender.NativeMethodInfoPtr_BlendIn_Protected_Abstract_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x000ABEEC File Offset: 0x000AA0EC
		[CallerCount(0)]
		public unsafe virtual void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeatureBlender.NativeMethodInfoPtr_BlendOut_Protected_Abstract_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x000ABF50 File Offset: 0x000AA150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89985, XrefRangeEnd = 89987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ProfileFeatureBlendingMode BlendingMode(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeatureBlender.NativeMethodInfoPtr_BlendingMode_Protected_Virtual_New_ProfileFeatureBlendingMode_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x000ABFC0 File Offset: 0x000AA1C0
		[CallerCount(0)]
		public unsafe virtual void Blend(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeatureBlender.NativeMethodInfoPtr_Blend_Public_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x000AC024 File Offset: 0x000AA224
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeatureBlender() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeatureBlender>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureBlender.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0000B496 File Offset: 0x00009696
		public FeatureBlender(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_get_featureKey_Protected_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_BlendBoth_Protected_Abstract_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_BlendIn_Protected_Abstract_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr_BlendOut_Protected_Abstract_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr_BlendingMode_Protected_Virtual_New_ProfileFeatureBlendingMode_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_Blend_Public_Virtual_New_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
