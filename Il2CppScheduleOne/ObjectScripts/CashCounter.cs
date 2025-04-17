using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000728 RID: 1832
	public class CashCounter : MonoBehaviour
	{
		// Token: 0x0600A572 RID: 42354 RVA: 0x00296BF4 File Offset: 0x00294DF4
		// Note: this type is marked as 'beforefieldinit'.
		static CashCounter()
		{
			Il2CppClassPointerStore<CashCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "CashCounter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashCounter>.NativeClassPtr);
			CashCounter.NativeFieldInfoPtr_NoteLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "NoteLerpTime");
			CashCounter.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "IsOn");
			CashCounter.NativeFieldInfoPtr_UpperNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "UpperNotes");
			CashCounter.NativeFieldInfoPtr_LowerNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "LowerNotes");
			CashCounter.NativeFieldInfoPtr_NoteStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "NoteStartPoint");
			CashCounter.NativeFieldInfoPtr_NoteEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "NoteEndPoint");
			CashCounter.NativeFieldInfoPtr_MovingNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "MovingNotes");
			CashCounter.NativeFieldInfoPtr_Audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "Audio");
			CashCounter.NativeFieldInfoPtr_lerping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "lerping");
			CashCounter.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, 100683534);
			CashCounter.NativeMethodInfoPtr_LerpNote_Private_IEnumerator_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, 100683535);
			CashCounter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, 100683536);
		}

		// Token: 0x0600A573 RID: 42355 RVA: 0x00296D14 File Offset: 0x00294F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289098, XrefRangeEnd = 289106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashCounter.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A574 RID: 42356 RVA: 0x00296D50 File Offset: 0x00294F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289106, XrefRangeEnd = 289112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpNote(Transform note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter.NativeMethodInfoPtr_LerpNote_Private_IEnumerator_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A575 RID: 42357 RVA: 0x00296DA0 File Offset: 0x00294FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289112, XrefRangeEnd = 289120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashCounter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashCounter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A576 RID: 42358 RVA: 0x000517F1 File Offset: 0x0004F9F1
		public CashCounter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600A577 RID: 42359 RVA: 0x00296DDC File Offset: 0x00294FDC
		// (set) Token: 0x0600A578 RID: 42360 RVA: 0x000517FA File Offset: 0x0004F9FA
		public unsafe static float NoteLerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashCounter.NativeFieldInfoPtr_NoteLerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashCounter.NativeFieldInfoPtr_NoteLerpTime, (void*)(&value));
			}
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600A579 RID: 42361 RVA: 0x00296DF8 File Offset: 0x00294FF8
		// (set) Token: 0x0600A57A RID: 42362 RVA: 0x00051808 File Offset: 0x0004FA08
		public unsafe bool IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600A57B RID: 42363 RVA: 0x00296E20 File Offset: 0x00295020
		// (set) Token: 0x0600A57C RID: 42364 RVA: 0x00051823 File Offset: 0x0004FA23
		public unsafe GameObject UpperNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_UpperNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_UpperNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600A57D RID: 42365 RVA: 0x00296E50 File Offset: 0x00295050
		// (set) Token: 0x0600A57E RID: 42366 RVA: 0x00051842 File Offset: 0x0004FA42
		public unsafe GameObject LowerNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_LowerNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_LowerNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600A57F RID: 42367 RVA: 0x00296E80 File Offset: 0x00295080
		// (set) Token: 0x0600A580 RID: 42368 RVA: 0x00051861 File Offset: 0x0004FA61
		public unsafe Transform NoteStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600A581 RID: 42369 RVA: 0x00296EB0 File Offset: 0x002950B0
		// (set) Token: 0x0600A582 RID: 42370 RVA: 0x00051880 File Offset: 0x0004FA80
		public unsafe Transform NoteEndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteEndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteEndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600A583 RID: 42371 RVA: 0x00296EE0 File Offset: 0x002950E0
		// (set) Token: 0x0600A584 RID: 42372 RVA: 0x0005189F File Offset: 0x0004FA9F
		public unsafe List<Transform> MovingNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_MovingNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_MovingNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600A585 RID: 42373 RVA: 0x00296F10 File Offset: 0x00295110
		// (set) Token: 0x0600A586 RID: 42374 RVA: 0x000518BE File Offset: 0x0004FABE
		public unsafe AudioSourceController Audio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_Audio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_Audio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600A587 RID: 42375 RVA: 0x00296F40 File Offset: 0x00295140
		// (set) Token: 0x0600A588 RID: 42376 RVA: 0x000518DD File Offset: 0x0004FADD
		public unsafe bool lerping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_lerping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_lerping)) = value;
			}
		}

		// Token: 0x04006EF2 RID: 28402
		private static readonly IntPtr NativeFieldInfoPtr_NoteLerpTime;

		// Token: 0x04006EF3 RID: 28403
		private static readonly IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x04006EF4 RID: 28404
		private static readonly IntPtr NativeFieldInfoPtr_UpperNotes;

		// Token: 0x04006EF5 RID: 28405
		private static readonly IntPtr NativeFieldInfoPtr_LowerNotes;

		// Token: 0x04006EF6 RID: 28406
		private static readonly IntPtr NativeFieldInfoPtr_NoteStartPoint;

		// Token: 0x04006EF7 RID: 28407
		private static readonly IntPtr NativeFieldInfoPtr_NoteEndPoint;

		// Token: 0x04006EF8 RID: 28408
		private static readonly IntPtr NativeFieldInfoPtr_MovingNotes;

		// Token: 0x04006EF9 RID: 28409
		private static readonly IntPtr NativeFieldInfoPtr_Audio;

		// Token: 0x04006EFA RID: 28410
		private static readonly IntPtr NativeFieldInfoPtr_lerping;

		// Token: 0x04006EFB RID: 28411
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04006EFC RID: 28412
		private static readonly IntPtr NativeMethodInfoPtr_LerpNote_Private_IEnumerator_Transform_0;

		// Token: 0x04006EFD RID: 28413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BCD RID: 3021
		[ObfuscatedName("ScheduleOne.ObjectScripts.CashCounter+<LerpNote>d__10")]
		public sealed class _LerpNote_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600DE29 RID: 56873 RVA: 0x00346AE0 File Offset: 0x00344CE0
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpNote_d__10()
			{
				Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "<LerpNote>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr);
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<>1__state");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<>2__current");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<>4__this");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "note");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<i>5__2");
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100683537);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100683538);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100683539);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100683540);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100683541);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100683542);
			}

			// Token: 0x0600DE2A RID: 56874 RVA: 0x00346BE8 File Offset: 0x00344DE8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpNote_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE2B RID: 56875 RVA: 0x00346C30 File Offset: 0x00344E30
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE2C RID: 56876 RVA: 0x00346C64 File Offset: 0x00344E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289069, XrefRangeEnd = 289093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044DE RID: 17630
			// (get) Token: 0x0600DE2D RID: 56877 RVA: 0x00346CA0 File Offset: 0x00344EA0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE2E RID: 56878 RVA: 0x00346CE0 File Offset: 0x00344EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289093, XrefRangeEnd = 289098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044DF RID: 17631
			// (get) Token: 0x0600DE2F RID: 56879 RVA: 0x00346D14 File Offset: 0x00344F14
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE30 RID: 56880 RVA: 0x0006C4EE File Offset: 0x0006A6EE
			public _LerpNote_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044D9 RID: 17625
			// (get) Token: 0x0600DE31 RID: 56881 RVA: 0x00346D54 File Offset: 0x00344F54
			// (set) Token: 0x0600DE32 RID: 56882 RVA: 0x0006C4F7 File Offset: 0x0006A6F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044DA RID: 17626
			// (get) Token: 0x0600DE33 RID: 56883 RVA: 0x00346D7C File Offset: 0x00344F7C
			// (set) Token: 0x0600DE34 RID: 56884 RVA: 0x0006C512 File Offset: 0x0006A712
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044DB RID: 17627
			// (get) Token: 0x0600DE35 RID: 56885 RVA: 0x00346DAC File Offset: 0x00344FAC
			// (set) Token: 0x0600DE36 RID: 56886 RVA: 0x0006C531 File Offset: 0x0006A731
			public unsafe CashCounter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashCounter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044DC RID: 17628
			// (get) Token: 0x0600DE37 RID: 56887 RVA: 0x00346DDC File Offset: 0x00344FDC
			// (set) Token: 0x0600DE38 RID: 56888 RVA: 0x0006C550 File Offset: 0x0006A750
			public unsafe Transform note
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr_note);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr_note), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044DD RID: 17629
			// (get) Token: 0x0600DE39 RID: 56889 RVA: 0x00346E0C File Offset: 0x0034500C
			// (set) Token: 0x0600DE3A RID: 56890 RVA: 0x0006C56F File Offset: 0x0006A76F
			public unsafe float _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040094BF RID: 38079
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094C0 RID: 38080
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094C1 RID: 38081
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094C2 RID: 38082
			private static readonly IntPtr NativeFieldInfoPtr_note;

			// Token: 0x040094C3 RID: 38083
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040094C4 RID: 38084
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094C5 RID: 38085
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094C6 RID: 38086
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094C7 RID: 38087
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094C8 RID: 38088
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094C9 RID: 38089
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
