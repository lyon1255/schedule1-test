using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E1 RID: 1249
	public class LoanSharkCarVisuals : MonoBehaviour
	{
		// Token: 0x06006E78 RID: 28280 RVA: 0x001E8CCC File Offset: 0x001E6ECC
		// Note: this type is marked as 'beforefieldinit'.
		static LoanSharkCarVisuals()
		{
			Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "LoanSharkCarVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr);
			LoanSharkCarVisuals.NativeFieldInfoPtr_Note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, "Note");
			LoanSharkCarVisuals.NativeFieldInfoPtr_BulletHoleDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, "BulletHoleDecals");
			LoanSharkCarVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, 100677280);
			LoanSharkCarVisuals.NativeMethodInfoPtr_Configure_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, 100677281);
			LoanSharkCarVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, 100677282);
		}

		// Token: 0x06006E79 RID: 28281 RVA: 0x001E8D60 File Offset: 0x001E6F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219948, XrefRangeEnd = 219953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoanSharkCarVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E7A RID: 28282 RVA: 0x001E8D94 File Offset: 0x001E6F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219953, XrefRangeEnd = 219956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(bool enabled, bool noteVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noteVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoanSharkCarVisuals.NativeMethodInfoPtr_Configure_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E7B RID: 28283 RVA: 0x001E8DE0 File Offset: 0x001E6FE0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoanSharkCarVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoanSharkCarVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E7C RID: 28284 RVA: 0x000343ED File Offset: 0x000325ED
		public LoanSharkCarVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x06006E7D RID: 28285 RVA: 0x001E8E1C File Offset: 0x001E701C
		// (set) Token: 0x06006E7E RID: 28286 RVA: 0x000343F6 File Offset: 0x000325F6
		public unsafe GameObject Note
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_Note);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_Note), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x06006E7F RID: 28287 RVA: 0x001E8E4C File Offset: 0x001E704C
		// (set) Token: 0x06006E80 RID: 28288 RVA: 0x00034415 File Offset: 0x00032615
		public unsafe GameObject BulletHoleDecals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_BulletHoleDecals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_BulletHoleDecals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B9C RID: 19356
		private static readonly IntPtr NativeFieldInfoPtr_Note;

		// Token: 0x04004B9D RID: 19357
		private static readonly IntPtr NativeFieldInfoPtr_BulletHoleDecals;

		// Token: 0x04004B9E RID: 19358
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004B9F RID: 19359
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_Boolean_Boolean_0;

		// Token: 0x04004BA0 RID: 19360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
