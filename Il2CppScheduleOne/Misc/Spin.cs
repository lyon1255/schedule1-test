using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x0200076E RID: 1902
	public class Spin : MonoBehaviour
	{
		// Token: 0x0600B496 RID: 46230 RVA: 0x002CF388 File Offset: 0x002CD588
		// Note: this type is marked as 'beforefieldinit'.
		static Spin()
		{
			Il2CppClassPointerStore<Spin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "Spin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spin>.NativeClassPtr);
			Spin.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spin>.NativeClassPtr, "Axis");
			Spin.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spin>.NativeClassPtr, "Speed");
			Spin.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spin>.NativeClassPtr, 100685518);
			Spin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spin>.NativeClassPtr, 100685519);
		}

		// Token: 0x0600B497 RID: 46231 RVA: 0x002CF408 File Offset: 0x002CD608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309343, XrefRangeEnd = 309346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spin.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B498 RID: 46232 RVA: 0x002CF43C File Offset: 0x002CD63C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B499 RID: 46233 RVA: 0x0005895C File Offset: 0x00056B5C
		public Spin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x0600B49A RID: 46234 RVA: 0x002CF478 File Offset: 0x002CD678
		// (set) Token: 0x0600B49B RID: 46235 RVA: 0x00058965 File Offset: 0x00056B65
		public unsafe Vector3 Axis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Axis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Axis)) = value;
			}
		}

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x0600B49C RID: 46236 RVA: 0x002CF4A0 File Offset: 0x002CD6A0
		// (set) Token: 0x0600B49D RID: 46237 RVA: 0x00058980 File Offset: 0x00056B80
		public unsafe float Speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Speed)) = value;
			}
		}

		// Token: 0x040079BA RID: 31162
		private static readonly IntPtr NativeFieldInfoPtr_Axis;

		// Token: 0x040079BB RID: 31163
		private static readonly IntPtr NativeFieldInfoPtr_Speed;

		// Token: 0x040079BC RID: 31164
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040079BD RID: 31165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
