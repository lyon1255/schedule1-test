using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F6 RID: 1526
	public class EyebrowController : MonoBehaviour
	{
		// Token: 0x06008676 RID: 34422 RVA: 0x00239088 File Offset: 0x00237288
		// Note: this type is marked as 'beforefieldinit'.
		static EyebrowController()
		{
			Il2CppClassPointerStore<EyebrowController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "EyebrowController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr);
			EyebrowController.NativeFieldInfoPtr_leftBrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, "leftBrow");
			EyebrowController.NativeFieldInfoPtr_rightBrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, "rightBrow");
			EyebrowController.NativeMethodInfoPtr_ApplySettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100680092);
			EyebrowController.NativeMethodInfoPtr_SetLeftBrowRestingHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100680093);
			EyebrowController.NativeMethodInfoPtr_SetRightBrowRestingHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100680094);
			EyebrowController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100680095);
		}

		// Token: 0x06008677 RID: 34423 RVA: 0x00239130 File Offset: 0x00237330
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 250744, RefRangeEnd = 250748, XrefRangeStart = 250732, XrefRangeEnd = 250744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr_ApplySettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x00239174 File Offset: 0x00237374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250748, XrefRangeEnd = 250750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLeftBrowRestingHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr_SetLeftBrowRestingHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008679 RID: 34425 RVA: 0x002391B4 File Offset: 0x002373B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250750, XrefRangeEnd = 250752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRightBrowRestingHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr_SetRightBrowRestingHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600867A RID: 34426 RVA: 0x002391F4 File Offset: 0x002373F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyebrowController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600867B RID: 34427 RVA: 0x0003FEBA File Offset: 0x0003E0BA
		public EyebrowController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028DC RID: 10460
		// (get) Token: 0x0600867C RID: 34428 RVA: 0x00239230 File Offset: 0x00237430
		// (set) Token: 0x0600867D RID: 34429 RVA: 0x0003FEC3 File Offset: 0x0003E0C3
		public unsafe Eyebrow leftBrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_leftBrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eyebrow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_leftBrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028DD RID: 10461
		// (get) Token: 0x0600867E RID: 34430 RVA: 0x00239260 File Offset: 0x00237460
		// (set) Token: 0x0600867F RID: 34431 RVA: 0x0003FEE2 File Offset: 0x0003E0E2
		public unsafe Eyebrow rightBrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_rightBrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eyebrow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_rightBrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005B86 RID: 23430
		private static readonly IntPtr NativeFieldInfoPtr_leftBrow;

		// Token: 0x04005B87 RID: 23431
		private static readonly IntPtr NativeFieldInfoPtr_rightBrow;

		// Token: 0x04005B88 RID: 23432
		private static readonly IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005B89 RID: 23433
		private static readonly IntPtr NativeMethodInfoPtr_SetLeftBrowRestingHeight_Public_Void_Single_0;

		// Token: 0x04005B8A RID: 23434
		private static readonly IntPtr NativeMethodInfoPtr_SetRightBrowRestingHeight_Public_Void_Single_0;

		// Token: 0x04005B8B RID: 23435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
