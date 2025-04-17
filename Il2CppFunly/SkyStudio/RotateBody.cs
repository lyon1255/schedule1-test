using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000DC RID: 220
	public class RotateBody : MonoBehaviour
	{
		// Token: 0x060011DD RID: 4573 RVA: 0x000A8920 File Offset: 0x000A6B20
		// Note: this type is marked as 'beforefieldinit'.
		static RotateBody()
		{
			Il2CppClassPointerStore<RotateBody>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RotateBody");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateBody>.NativeClassPtr);
			RotateBody.NativeFieldInfoPtr_m_SpinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateBody>.NativeClassPtr, "m_SpinSpeed");
			RotateBody.NativeFieldInfoPtr_m_AllowSpinning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateBody>.NativeClassPtr, "m_AllowSpinning");
			RotateBody.NativeMethodInfoPtr_get_SpinSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateBody>.NativeClassPtr, 100665345);
			RotateBody.NativeMethodInfoPtr_set_SpinSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateBody>.NativeClassPtr, 100665346);
			RotateBody.NativeMethodInfoPtr_get_AllowSpinning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateBody>.NativeClassPtr, 100665347);
			RotateBody.NativeMethodInfoPtr_set_AllowSpinning_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateBody>.NativeClassPtr, 100665348);
			RotateBody.NativeMethodInfoPtr_UpdateOrbitBodyRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateBody>.NativeClassPtr, 100665349);
			RotateBody.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateBody>.NativeClassPtr, 100665350);
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x000A89F0 File Offset: 0x000A6BF0
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x000A8A2C File Offset: 0x000A6C2C
		public unsafe float SpinSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateBody.NativeMethodInfoPtr_get_SpinSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88545, XrefRangeEnd = 88759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateBody.NativeMethodInfoPtr_set_SpinSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x000A8A6C File Offset: 0x000A6C6C
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x000A8AA8 File Offset: 0x000A6CA8
		public unsafe bool AllowSpinning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateBody.NativeMethodInfoPtr_get_AllowSpinning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88759, XrefRangeEnd = 88760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateBody.NativeMethodInfoPtr_set_AllowSpinning_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x000A8AE8 File Offset: 0x000A6CE8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 88768, RefRangeEnd = 88777, XrefRangeStart = 88760, XrefRangeEnd = 88768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOrbitBodyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateBody.NativeMethodInfoPtr_UpdateOrbitBodyRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x000A8B1C File Offset: 0x000A6D1C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotateBody() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateBody>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateBody.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0000ADF1 File Offset: 0x00008FF1
		public RotateBody(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000A8B58 File Offset: 0x000A6D58
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x0000ADFA File Offset: 0x00008FFA
		public unsafe float m_SpinSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateBody.NativeFieldInfoPtr_m_SpinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateBody.NativeFieldInfoPtr_m_SpinSpeed)) = value;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x000A8B80 File Offset: 0x000A6D80
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x0000AE15 File Offset: 0x00009015
		public unsafe bool m_AllowSpinning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateBody.NativeFieldInfoPtr_m_AllowSpinning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateBody.NativeFieldInfoPtr_m_AllowSpinning)) = value;
			}
		}

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeFieldInfoPtr_m_SpinSpeed;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowSpinning;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr_get_SpinSpeed_Public_get_Single_0;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr_set_SpinSpeed_Public_set_Void_Single_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowSpinning_Public_get_Boolean_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowSpinning_Public_set_Void_Boolean_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOrbitBodyRotation_Public_Void_0;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
