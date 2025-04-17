using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map.Infrastructure
{
	// Token: 0x0200078A RID: 1930
	public class TrafficLight : MonoBehaviour
	{
		// Token: 0x0600B6C5 RID: 46789 RVA: 0x002D5B00 File Offset: 0x002D3D00
		// Note: this type is marked as 'beforefieldinit'.
		static TrafficLight()
		{
			Il2CppClassPointerStore<TrafficLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map.Infrastructure", "TrafficLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr);
			TrafficLight.NativeFieldInfoPtr_amberTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "amberTime");
			TrafficLight.NativeFieldInfoPtr_redMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "redMesh");
			TrafficLight.NativeFieldInfoPtr_orangeMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "orangeMesh");
			TrafficLight.NativeFieldInfoPtr_greenMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "greenMesh");
			TrafficLight.NativeFieldInfoPtr_redOn_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "redOn_Mat");
			TrafficLight.NativeFieldInfoPtr_redOff_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "redOff_Mat");
			TrafficLight.NativeFieldInfoPtr_orangeOn_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "orangeOn_Mat");
			TrafficLight.NativeFieldInfoPtr_orangeOff_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "orangeOff_Mat");
			TrafficLight.NativeFieldInfoPtr_greenOn_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "greenOn_Mat");
			TrafficLight.NativeFieldInfoPtr_greenOff_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "greenOff_Mat");
			TrafficLight.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "state");
			TrafficLight.NativeFieldInfoPtr_appliedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "appliedState");
			TrafficLight.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100685754);
			TrafficLight.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100685755);
			TrafficLight.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100685756);
			TrafficLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100685757);
		}

		// Token: 0x0600B6C6 RID: 46790 RVA: 0x002D5C70 File Offset: 0x002D3E70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310930, RefRangeEnd = 310932, XrefRangeStart = 310930, XrefRangeEnd = 310932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrafficLight.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6C7 RID: 46791 RVA: 0x002D5CAC File Offset: 0x002D3EAC
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrafficLight.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6C8 RID: 46792 RVA: 0x002D5CE8 File Offset: 0x002D3EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311486, XrefRangeEnd = 311490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrafficLight.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6C9 RID: 46793 RVA: 0x002D5D24 File Offset: 0x002D3F24
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrafficLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrafficLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6CA RID: 46794 RVA: 0x00059C8B File Offset: 0x00057E8B
		public TrafficLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x0600B6CB RID: 46795 RVA: 0x002D5D60 File Offset: 0x002D3F60
		// (set) Token: 0x0600B6CC RID: 46796 RVA: 0x00059C94 File Offset: 0x00057E94
		public unsafe static float amberTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrafficLight.NativeFieldInfoPtr_amberTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrafficLight.NativeFieldInfoPtr_amberTime, (void*)(&value));
			}
		}

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x0600B6CD RID: 46797 RVA: 0x002D5D7C File Offset: 0x002D3F7C
		// (set) Token: 0x0600B6CE RID: 46798 RVA: 0x00059CA2 File Offset: 0x00057EA2
		public unsafe MeshRenderer redMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x0600B6CF RID: 46799 RVA: 0x002D5DAC File Offset: 0x002D3FAC
		// (set) Token: 0x0600B6D0 RID: 46800 RVA: 0x00059CC1 File Offset: 0x00057EC1
		public unsafe MeshRenderer orangeMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x0600B6D1 RID: 46801 RVA: 0x002D5DDC File Offset: 0x002D3FDC
		// (set) Token: 0x0600B6D2 RID: 46802 RVA: 0x00059CE0 File Offset: 0x00057EE0
		public unsafe MeshRenderer greenMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x0600B6D3 RID: 46803 RVA: 0x002D5E0C File Offset: 0x002D400C
		// (set) Token: 0x0600B6D4 RID: 46804 RVA: 0x00059CFF File Offset: 0x00057EFF
		public unsafe Material redOn_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redOn_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redOn_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x0600B6D5 RID: 46805 RVA: 0x002D5E3C File Offset: 0x002D403C
		// (set) Token: 0x0600B6D6 RID: 46806 RVA: 0x00059D1E File Offset: 0x00057F1E
		public unsafe Material redOff_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redOff_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redOff_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x0600B6D7 RID: 46807 RVA: 0x002D5E6C File Offset: 0x002D406C
		// (set) Token: 0x0600B6D8 RID: 46808 RVA: 0x00059D3D File Offset: 0x00057F3D
		public unsafe Material orangeOn_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeOn_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeOn_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x0600B6D9 RID: 46809 RVA: 0x002D5E9C File Offset: 0x002D409C
		// (set) Token: 0x0600B6DA RID: 46810 RVA: 0x00059D5C File Offset: 0x00057F5C
		public unsafe Material orangeOff_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeOff_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeOff_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x0600B6DB RID: 46811 RVA: 0x002D5ECC File Offset: 0x002D40CC
		// (set) Token: 0x0600B6DC RID: 46812 RVA: 0x00059D7B File Offset: 0x00057F7B
		public unsafe Material greenOn_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenOn_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenOn_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x0600B6DD RID: 46813 RVA: 0x002D5EFC File Offset: 0x002D40FC
		// (set) Token: 0x0600B6DE RID: 46814 RVA: 0x00059D9A File Offset: 0x00057F9A
		public unsafe Material greenOff_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenOff_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenOff_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0600B6DF RID: 46815 RVA: 0x002D5F2C File Offset: 0x002D412C
		// (set) Token: 0x0600B6E0 RID: 46816 RVA: 0x00059DB9 File Offset: 0x00057FB9
		public unsafe TrafficLight.State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0600B6E1 RID: 46817 RVA: 0x002D5F54 File Offset: 0x002D4154
		// (set) Token: 0x0600B6E2 RID: 46818 RVA: 0x00059DD4 File Offset: 0x00057FD4
		public unsafe TrafficLight.State appliedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_appliedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_appliedState)) = value;
			}
		}

		// Token: 0x04007B18 RID: 31512
		private static readonly IntPtr NativeFieldInfoPtr_amberTime;

		// Token: 0x04007B19 RID: 31513
		private static readonly IntPtr NativeFieldInfoPtr_redMesh;

		// Token: 0x04007B1A RID: 31514
		private static readonly IntPtr NativeFieldInfoPtr_orangeMesh;

		// Token: 0x04007B1B RID: 31515
		private static readonly IntPtr NativeFieldInfoPtr_greenMesh;

		// Token: 0x04007B1C RID: 31516
		private static readonly IntPtr NativeFieldInfoPtr_redOn_Mat;

		// Token: 0x04007B1D RID: 31517
		private static readonly IntPtr NativeFieldInfoPtr_redOff_Mat;

		// Token: 0x04007B1E RID: 31518
		private static readonly IntPtr NativeFieldInfoPtr_orangeOn_Mat;

		// Token: 0x04007B1F RID: 31519
		private static readonly IntPtr NativeFieldInfoPtr_orangeOff_Mat;

		// Token: 0x04007B20 RID: 31520
		private static readonly IntPtr NativeFieldInfoPtr_greenOn_Mat;

		// Token: 0x04007B21 RID: 31521
		private static readonly IntPtr NativeFieldInfoPtr_greenOff_Mat;

		// Token: 0x04007B22 RID: 31522
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04007B23 RID: 31523
		private static readonly IntPtr NativeFieldInfoPtr_appliedState;

		// Token: 0x04007B24 RID: 31524
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007B25 RID: 31525
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007B26 RID: 31526
		private static readonly IntPtr NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_0;

		// Token: 0x04007B27 RID: 31527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C09 RID: 3081
		[OriginalName("Assembly-CSharp.dll", "", "State")]
		public enum State
		{
			// Token: 0x0400962D RID: 38445
			Red,
			// Token: 0x0400962E RID: 38446
			Orange,
			// Token: 0x0400962F RID: 38447
			Green
		}
	}
}
