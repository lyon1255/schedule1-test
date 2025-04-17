using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Decoration
{
	// Token: 0x02000766 RID: 1894
	public class RockerSwitch : MonoBehaviour
	{
		// Token: 0x0600B3D9 RID: 46041 RVA: 0x002CD1DC File Offset: 0x002CB3DC
		// Note: this type is marked as 'beforefieldinit'.
		static RockerSwitch()
		{
			Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Decoration", "RockerSwitch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr);
			RockerSwitch.NativeFieldInfoPtr_ButtonMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "ButtonMesh");
			RockerSwitch.NativeFieldInfoPtr_ButtonTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "ButtonTransform");
			RockerSwitch.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "Light");
			RockerSwitch.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "isOn");
			RockerSwitch.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, 100685459);
			RockerSwitch.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, 100685460);
			RockerSwitch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, 100685461);
		}

		// Token: 0x0600B3DA RID: 46042 RVA: 0x002CD298 File Offset: 0x002CB498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308678, XrefRangeEnd = 308679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockerSwitch.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3DB RID: 46043 RVA: 0x002CD2CC File Offset: 0x002CB4CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308682, RefRangeEnd = 308684, XrefRangeStart = 308679, XrefRangeEnd = 308682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockerSwitch.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3DC RID: 46044 RVA: 0x002CD30C File Offset: 0x002CB50C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RockerSwitch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockerSwitch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3DD RID: 46045 RVA: 0x0005827A File Offset: 0x0005647A
		public RockerSwitch(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x0600B3DE RID: 46046 RVA: 0x002CD348 File Offset: 0x002CB548
		// (set) Token: 0x0600B3DF RID: 46047 RVA: 0x00058283 File Offset: 0x00056483
		public unsafe MeshRenderer ButtonMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x0600B3E0 RID: 46048 RVA: 0x002CD378 File Offset: 0x002CB578
		// (set) Token: 0x0600B3E1 RID: 46049 RVA: 0x000582A2 File Offset: 0x000564A2
		public unsafe Transform ButtonTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x0600B3E2 RID: 46050 RVA: 0x002CD3A8 File Offset: 0x002CB5A8
		// (set) Token: 0x0600B3E3 RID: 46051 RVA: 0x000582C1 File Offset: 0x000564C1
		public unsafe Light Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x0600B3E4 RID: 46052 RVA: 0x002CD3D8 File Offset: 0x002CB5D8
		// (set) Token: 0x0600B3E5 RID: 46053 RVA: 0x000582E0 File Offset: 0x000564E0
		public unsafe bool isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_isOn)) = value;
			}
		}

		// Token: 0x04007948 RID: 31048
		private static readonly IntPtr NativeFieldInfoPtr_ButtonMesh;

		// Token: 0x04007949 RID: 31049
		private static readonly IntPtr NativeFieldInfoPtr_ButtonTransform;

		// Token: 0x0400794A RID: 31050
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x0400794B RID: 31051
		private static readonly IntPtr NativeFieldInfoPtr_isOn;

		// Token: 0x0400794C RID: 31052
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400794D RID: 31053
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0;

		// Token: 0x0400794E RID: 31054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
